using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepa.Models;
using Yepa.Helpers;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace Yepa.Services 
{
    public class FirebaseRTDBService 
    {

        #region FIREBASE

        public FirebaseClient FirebaseClient { get; private set; }

        public FirebaseRTDBService() { }

        //private readonly RealtimeDatabase<T> _realtimeDb;

        public void Initialize() 
        { 
            FirebaseClient = new FirebaseClient("https://yepa-maleon-21-default-rtdb.firebaseio.com/",
                new FirebaseOptions 
                { 
                    AuthTokenAsyncFactory = () => Task.FromResult(SecureStorage.GetAsync("FirebaseToken").Result)
                });
        }

        public void Destroy()
        {
            FirebaseClient?.Dispose();
        }

        #endregion


        #region CLIENT

        public async Task AddClient(ClientInfoModel clientInfoModel , string id) 
        {
            var setClientModel = new FirebaseClientModel (clientInfoModel);
            await FirebaseClient.Child($"Clients/{id}").PutAsync(setClientModel);
        }

        public async Task UpdateClient(UserInfoModel ChangeableClientInformationModel, string country, string id) 
        {
            await FirebaseClient.Child($"Clients/{country}/{id}/Information/ChangeableInformation").PatchAsync(ChangeableClientInformationModel);
        }

        public async Task<UserInfoModel> GetClientProfileData(string id) 
        {
            return await FirebaseClient.Child($"Clients/{id}/Info/SimpleInfo").OnceSingleAsync<UserInfoModel>(); ;
        }

        public async Task<ClientInfoModel> GetClientIrformation(string id) 
        {
            return await FirebaseClient.Child($"Clients/{id}/Info").OnceSingleAsync<ClientInfoModel>(); 
        }

        public async Task<DateTime> GetClientModificationDate(string id)
        {
            return await FirebaseClient.Child($"Clients/{id}/Info/SimpleInfo/ModificationDate").OnceSingleAsync<DateTime>();
        }

        public async Task<ObservableCollection<ChatRegisterModel>> GetChatRegisters(string id) 
        {
            var getChatRegisters = (await FirebaseClient.Child($"ChatsRegisters/{id}").OnceAsync<ChatRegisterModel>()).Select(item => item.Object).ToList();
            var toObservableCollection = new ObservableCollection<ChatRegisterModel>();
            foreach (var item in getChatRegisters)
            {
                toObservableCollection.Add(item);
            }
            return toObservableCollection;
        }

        #endregion


        #region CHAT

        /// <summary>
        /// Adds the chat in the database. 
        /// </summary>
        /// <param name="chatInfoModel"></param>
        /// <returns> 
        /// The key or ID of the chat in the database. 
        /// </returns>
        public async Task<string> AddChat(ChatInfoModel chatInfoModel) 
        {
            try
            {
                var addChat = await FirebaseClient.Child("Chats").PostAsync(new FirebaseChatModel(chatInfoModel),false);
                await FirebaseClient.Child($"Chats/{addChat.Key}/Messages").PostAsync(new MessageModel(null,1,chatInfoModel.CreationDate), false);
                await FirebaseClient.Child($"Clients/{chatInfoModel.ClientID}/Chats/{chatInfoModel.WorkerID}").PutAsync(new ChatRegisterModel(addChat.Key));
                await FirebaseClient.Child($"Workers/{chatInfoModel.WorkerID}/Chats/{chatInfoModel.ClientID}").PutAsync(new ChatRegisterModel(addChat.Key));
                return addChat.Key;
            }
            catch(FirebaseException)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// It gets the chat using its key in the database.
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>
        /// A ChatInfoModel
        /// </returns>
        public async Task<ChatInfoModel> GetChatInformation(string Key) 
        {
            return await FirebaseClient.Child($"Chats/{Key}/Info").OnceSingleAsync<ChatInfoModel>();
        }

        public async Task DeleteChat(string Key, ChatRegisterModel chatRegisterModel) 
        {
            var getChatRegister = FirebaseClient.Child($"Workers/{chatRegisterModel.UserID}/ChatsRegisters/{chatRegisterModel.KeyChat}").OnceSingleAsync<ChatRegisterModel>();
            await FirebaseClient.Child($"Clients/{Key}/ChatsRegisters/{chatRegisterModel.KeyChat}").DeleteAsync();
            if (getChatRegister == null) 
            {
                return;
            }
            else 
            {
                await FirebaseClient.Child($"Chats/{chatRegisterModel.KeyChat}").DeleteAsync();
                await FirebaseClient.Child($"Workers/{chatRegisterModel.UserID}/ChatsRegisters/{chatRegisterModel.KeyChat}").DeleteAsync();
            }
        }

        /// <summary>
        /// It sets the user's connection status, true if connected or false if disconnected. 
        /// </summary>
        /// <param name="Connected"> </param>
        /// <param name="Key"> CountryCode and ClientID </param>
        /// <returns></returns>
        public async Task SetConnection(bool Connected, string id) 
        {
            await FirebaseClient.Child($"Clients/{id}/Connection/IsConnected").PutAsync(Connected);
        }

        ///<summary> Verify if exist a Chat Register. </summary>
        ///<param name="ReadClient"> workerId will be passed when starting this program. </param>
        ///<param name="Key"> workerId will be passed when starting this program. </param>
        ///<returns> True if exist or False if not exist.</returns>
        public async Task SetLastConnectionClient(DateTime LastConnectionClient, string Key) 
        {
            await FirebaseClient.Child($"Chats/{Key}/Connection/LastConnectionClient").PutAsync(LastConnectionClient);
        }

        ///<summary> Check if the chat log exists.. </summary>
        ///<returns> True if exist or False if not exist.</returns>
        public async Task<bool> VerifyChatExistence(string workerID, string clientID) 
        {
            try
            {
                var toSearchAllChats = await FirebaseClient.Child($"Clients/{clientID}/Chats/{workerID}/KeyChat").OnceSingleAsync<string>() ?? string.Empty;
                if (string.IsNullOrEmpty(toSearchAllChats))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<DateTime> GetModificationDate(string Key)
        {
            return await FirebaseClient.Child($"Chats/{Key}/Information/ModificationDate").OnceSingleAsync<DateTime>();
        }

        #endregion


        #region MESSAGES

        /// <summary>
        /// Post a messages in database. 
        /// </summary>
        /// <param name="messageModel"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public async Task AddMessage(MessageModel messageModel, string Key) 
        {
            await FirebaseClient.Child($"Chats/{Key}/Messages").PostAsync(messageModel, false);
            await FirebaseClient.Child($"Chats/{Key}/Connection/ModificationDate").PutAsync(messageModel.CreationDate);
        }

        #endregion


        #region WORKER

        public async Task<List<WorkerPrincipalData>> GetWorkers(string idcategory,int option) 
        {
            var location = LocationHelper.Placemark.Location;
            var getAreas = LocationHelper.GetAreas();

            var setPath = $"{getAreas[option].Area[0].Latitude};{getAreas[option].Area[0].Longitude}|" +
                $"{getAreas[option].Area[1].Latitude};{getAreas[option].Area[1].Longitude}|" +
                $"{getAreas[option].Area[2].Latitude};{getAreas[option].Area[2].Longitude}|" +
                $"{getAreas[option].Area[3].Latitude};{getAreas[option].Area[3].Longitude}";
            setPath = setPath.Replace(".", ",");

            var getAllWorkers = (await FirebaseClient.Child($"WorkerServices/{idcategory}/{setPath}").OnceAsync<FirebaseWorkerPrincipalData>()).
                Select(item => new WorkerPrincipalData() 
                {
                    Distance = Location.CalculateDistance(location.Latitude, location.Longitude, item.Object.Latitude, item.Object.Longitude,DistanceUnits.Kilometers),
                    // LocationHelper.GetDistanceToString(location.Latitude,location.Longitude, item.Object.Latitude, item.Object.Longitude),
                    ID = item.Key,
                    FirstName = item.Object.FirstName,
                    LastName = item.Object.LastName,
                    RatingsValue = Math.Round(item.Object.RatingsValue, 1),
                    Latitude = item.Object.Latitude,
                    Longitude = item.Object.Longitude,
                    ProfileImage = "Icon_UserWorker",
                }).ToList();
            return getAllWorkers;
        }

        public async Task<WorkerInfoModel> GetWorker(string Key) 
        {
            return await FirebaseClient.Child($"Workers/{Key}/Info").OnceSingleAsync<WorkerInfoModel>();
        }

        public async Task<RatingModel> GetWorkerRating(string Key) 
        {
            var getRating = await FirebaseClient.Child($"Workers/{Key}/Information/ChageableInformation/Rating").OnceSingleAsync<RatingModel>();
            return getRating;
        }

        public async Task UpdateRating(string Key, double RatingValue, string ClientID) {
            var getRating = await GetWorkerRating(Key);

            await FirebaseClient.Child($"Workers/{Key}/Information/ChageableInformation/Rating").PatchAsync(new RatingModel() {
                NumberRatings = getRating.NumberRatings++,
                RatingsValue = ((getRating.RatingsValue * getRating.NumberRatings) + RatingValue) / getRating.NumberRatings++,
            } );

            await FirebaseClient.Child($"Workers/{Key}/ClientsRegisters/{ClientID}").DeleteAsync();
        }

        ///<summary> Verify if exist a Client Register. </summary>
        ///<returns> True if exist or False if not exist.</returns>
        public async Task<bool> VerifyClientRegisterExistence(string workerId, string clientId) 
        {
            var toSearchAllChats = (await FirebaseClient.Child($"ClientsRegisters/{workerId}").OnceAsync<ClientIDModel>())
                 .Where(item => item.Object.ClientID == clientId).LongCount();
            if (toSearchAllChats == 0) 
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }

        #endregion


        #region PROBLEMS - RECOMMENDATIONS - COMMENT

        public async Task ReportProblem(string messageProblem, string Country) {
            await FirebaseClient.Child("Problems").Child(Country).PostAsync(new CommentModel() {
                Date = DateTime.Now.ToUniversalTime(),
                Message = messageProblem
                } );
        }

        public async Task CommentsRecommendations(string commentsRecommendations, string Country) {
            await FirebaseClient.Child("Comments-Recommendations").Child(Country).PostAsync(new CommentModel() {
                Date = DateTime.Now.ToUniversalTime(),
                Message = commentsRecommendations
            } );
        }

        #endregion


        #region WORKER

        public async Task AddWorker(WorkerInfoModel workerInfoModel, string id) 
        {
            var setWorkerModel = new FirebaseWorkerModel(workerInfoModel);
            var setWorkerPrincipalData = new FirebaseWorkerPrincipalData(workerInfoModel);
            await FirebaseClient.Child($"Workers/{id}").PutAsync(setWorkerModel);
            var getAreas = LocationHelper.GetAreas();
            var setPath =  $"{getAreas[0].Area[0].Latitude};{getAreas[0].Area[0].Longitude}|" +
                $"{getAreas[0].Area[1].Latitude};{getAreas[0].Area[1].Longitude}|" +
                $"{getAreas[0].Area[2].Latitude};{getAreas[0].Area[2].Longitude}|" +
                $"{getAreas[0].Area[3].Latitude};{getAreas[0].Area[3].Longitude}";
            setPath = setPath.Replace(".", ",");
            await FirebaseClient.Child($"WorkerServices/{workerInfoModel.StaticInfo.Subcategory}/{setPath}/{id}").PutAsync(setWorkerPrincipalData);
            //await FirebaseClient.Child($"Workers/{workerInfoModel.StaticInfo.Subcategory}/{workerInfoModel.StaticInfo.CountryCode}/{getArea}/{id}").PutAsync(true);
        }

        public async Task UpdateWorker(UserInfoModel chageableWorkerInformationModel , string category, string country, string id) 
        {
            await FirebaseClient.Child($"Workers/{country}/{category}/{id}/Information/ChangeableInformation").PatchAsync(chageableWorkerInformationModel);
        }

        #endregion


    }
    
    class FirebaseClientModel 
    { 
        public FirebaseClientModel(ClientInfoModel clientInfoModel) 
        {
            Chats = new Dictionary<string, string>();
            Connection = new UserConnectionModel(false);
            Info = clientInfoModel ?? new ClientInfoModel();
        }

        public ClientInfoModel Info { get; set; }
        public UserConnectionModel Connection { get; set; }
        public Dictionary<string,string> Chats { get; set; } = new Dictionary<string, string>();
    }

    class FirebaseWorkerModel 
    { 
        public FirebaseWorkerModel(WorkerInfoModel workerInfoModel) 
        {
            Chats = new string[] { "" };
            Clients = new bool[] { false };
            Info = workerInfoModel;
            Connection = new UserConnectionModel(false);
        }

        public WorkerInfoModel Info { get; set; }
        public UserConnectionModel Connection { get; set; }
        public string[] Chats { get; set; } = new string[] { "" };
        public bool[] Clients { get; set; } = new bool[] { false };
    }

    public class FirebaseWorkerPrincipalData
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
        public double RatingsValue { get; set; } = 0.0;
        public string ProfileImage { get; set; } = "Icon_Worker";

        public FirebaseWorkerPrincipalData() { }

        public FirebaseWorkerPrincipalData(WorkerInfoModel workerInfoModel)
        {
            FirstName = workerInfoModel.SimpleInfo.FirstName;
            LastName = workerInfoModel.SimpleInfo.LastName;
            Latitude = workerInfoModel.Location.Latitude;
            Longitude = workerInfoModel.Location.Longitude;
            RatingsValue = workerInfoModel.Rating.RatingsValue;
        }
    }

    class FirebaseChatModel
    {
        public FirebaseChatModel(ChatInfoModel chatInfo)
        {
            Info = chatInfo ?? new ChatInfoModel();
            Connection = new ChatConnectionModel();
        }

        /// <summary>
        /// Information of chat
        /// </summary>
        public ChatInfoModel Info { get; set; }

        public ChatConnectionModel Connection { get; set; } = new ChatConnectionModel();
    }
}
