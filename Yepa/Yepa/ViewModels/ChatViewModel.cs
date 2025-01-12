using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Yepa.Models;
using Yepa.Views.Home;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Yepa.ViewModels
{
    public class ChatViewModel : BaseViewModel 
    {

        #region Constructor

        public ChatViewModel(ClientRepository _clientRepository, ObservableCollection<ChatRegisterModel> _chatRegisterModels)  
        {
            IsEnabled = false;
            _ = LoadData();
            ClientRepository = _clientRepository ?? ClientRepository;
            chatRegisterModels = _chatRegisterModels ?? chatRegisterModels;
            MessagingCenter.Subscribe<ClientRepository>(this, "UpdateProfile", (newClientRepository) => 
            {
                ClientRepository = newClientRepository ?? ClientRepository;
            });

            MessagingCenter.Subscribe<string>(this, "OpenChat", async (workerID) =>
            {
                var getChat = ChatModels.Where(i => i.Info.WorkerID == workerID).FirstOrDefault();
                await OpenChatMethod(getChat.Info);
            });
            IsEnabled = true;
        }

        #endregion


        #region Destructor    

        public async Task Destroy()
        {
            Socket.Dispose();
            await Task.Delay(1);
        }

        #endregion


        #region Attributes

        readonly ObservableCollection<ChatRegisterModel> chatRegisterModels = new ObservableCollection<ChatRegisterModel>();
        List<ChatRepository> chatsRepositories = new List<ChatRepository>();
        private IDisposable Socket = null;
        private ClientRepository clientRepository = new ClientRepository();
        ObservableCollection<ChatModel> chatModels = new ObservableCollection<ChatModel>();
        bool isEnabled;

        #endregion


        #region Properties

        public ClientRepository ClientRepository
        {
            get { return clientRepository; }
            set { SetValue(ref clientRepository, value); }
        }

        public ObservableCollection<ChatModel> ChatModels 
        {
            get { return chatModels; }
            set { SetValue(ref chatModels, value); }
        }

        public bool IsEnabled 
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        #endregion


        #region Commands

        public ICommand OpenWorkerProfileCommand
        {
            get { return new RelayCommand<string>(async id => await OpenWorkerProfileMethod(id)); }
        }

        public ICommand OpenChatCommand
        {
            get { return new RelayCommand<ChatInfoModel>(async chatInfo => await OpenChatMethod(chatInfo)); }
        }
        /* PROBAR
        public ICommand LongPressedCommand 
        {
            get { return new RelayCommand<bool>(value => ActivateSocketsMethod(value)); }
        }
        */
        #endregion


        #region Methods

        public async Task LoadData()
        {
            try 
            {
                chatsRepositories = await App.Database.GetAllChatRepository(clientRepository.ClientID) ?? new List<ChatRepository>();
                foreach (var Ingredient in chatsRepositories)
                {
                    var chatItemModel = new ChatModel();

                    chatItemModel = new ChatModel
                    {
                        IsVisible = false,
                        Info = new ChatInfoModel(Ingredient)
                    }; 

                    if (chatItemModel.Connection.ModificationDate > chatItemModel.Connection.LastConnectionClient)
                    {
                        chatItemModel.IsVisible = true;
                    }

                    ChatModels.Add(new ChatModel
                    {
                        Key = Ingredient.Key,
                        Info = chatItemModel.Info,
                        IsVisible = chatItemModel.IsVisible,
                        MessagesListener = DefineSockets(Ingredient.Key, Ingredient.WorkerID),
                    });
                }


                Socket = App.FirebaseRTDBService.FirebaseClient.Child($"Clients/{ClientRepository.ClientID}/Chats")
                    .AsObservable<ChatRegisterModel>().Subscribe(async item =>
                    {
                        if (item.Object.KeyChat != string.Empty && item.Key != "0")
                        {
                            if (!chatRegisterModels.Any(i => item.Object.KeyChat == i.KeyChat))
                            {
                                var toChat = new ChatModel()
                                {
                                    Info = await App.FirebaseRTDBService.GetChatInformation(item.Object.KeyChat),
                                    IsVisible = true,
                                    Key = item.Object.KeyChat,
                                    MessagesListener =  DefineSockets(item.Object.KeyChat, item.Object.UserID)
                                };
                                ChatModels.Add(toChat);
                                ChatModels = new ObservableCollection<ChatModel>(ChatModels.OrderByDescending(i => i.Connection.ModificationDate));
                                await App.Database.SaveChatRepositoryAsync(new ChatRepository(toChat.Key,toChat.Info));
                                chatsRepositories.Add(await App.Database.GetChatRepositoryAynsc(toChat.Info.WorkerID, toChat.Info.ClientID));
                            }
                        }
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
            }
        }

        private void ActivateSockets(bool ActiveSockets) 
        {
            if (ActiveSockets) 
            {
                foreach (var chatsSocketModel in ChatModels) 
                {
                    chatsSocketModel.MessagesListener = App.FirebaseRTDBService.FirebaseClient.Child($"Chats/{chatsSocketModel.Key}/Info/Connection")
                    .AsObservable<ChatConnectionModel>().Subscribe(item => {
                        if (item.Object.ModificationDate > chatsSocketModel.Connection.ModificationDate
                        || item.Object.LastConnectionClient > chatsSocketModel.Connection.LastConnectionClient
                        || item.Object.LastConnectionClient < item.Object.ModificationDate) {
                            var getDateNow = DateTime.Now.ToLocalTime().AddSeconds(-2.0);
                            var getChat = ChatModels.IndexOf(ChatModels.Where(i => i.Info.WorkerID == chatsSocketModel.Info.WorkerID).FirstOrDefault());

                            if (item.Object.ModificationDate > item.Object.LastConnectionClient
                            || item.Object.ModificationDate > chatsSocketModel.Connection.ModificationDate) {
                                var chatsItemModelsTwo = ChatModels;
                                chatsItemModelsTwo[getChat].IsVisible = true;
                                chatsItemModelsTwo[getChat].Connection = item.Object;
                                //chatsItemModelsTwo = new ObservableCollection<ChatItemModel>(chatsItemModelsTwo.OrderBy(i => i.Chat.Information.ModificationDate));
                                chatsItemModelsTwo = new ObservableCollection<ChatModel>(chatsItemModelsTwo.OrderByDescending(i => i.Connection.ModificationDate));
                                ChatModels = new ObservableCollection<ChatModel>(chatsItemModelsTwo);
                            }
                        }
                    });
                }
            }
        }

        private IDisposable DefineSockets(string keyChat, string workerID) 
        {
            int getIndexChatItem = ChatModels.IndexOf(ChatModels.Where(item => item.Info.WorkerID == workerID).FirstOrDefault());
            IDisposable disposable = (App.FirebaseRTDBService.FirebaseClient.Child($"Chats/{keyChat}/Connection")
                .AsObservable<ChatConnectionModel>().Subscribe(item => 
                {
                    if (item.Object.ModificationDate > ChatModels[getIndexChatItem].Connection.ModificationDate
                    || item.Object.LastConnectionClient > ChatModels[getIndexChatItem].Connection.LastConnectionClient
                    || item.Object.LastConnectionClient < item.Object.ModificationDate) 
                    {
                        var getDateNow = DateTime.Now.ToLocalTime().AddSeconds(-2.0);
                        var getChat = ChatModels.IndexOf(ChatModels.Where(i => i.Info.WorkerID == workerID).FirstOrDefault());
                        if (item.Object.ModificationDate > item.Object.LastConnectionClient
                        || item.Object.ModificationDate > ChatModels[getIndexChatItem].Connection.ModificationDate) 
                        {
                            var chatsItemModelsTwo = ChatModels;
                            chatsItemModelsTwo[getChat].IsVisible = true;
                            chatsItemModelsTwo[getChat].Connection = item.Object;
                            chatsItemModelsTwo = new ObservableCollection<ChatModel>(chatsItemModelsTwo.OrderByDescending(i => i.Connection.ModificationDate));
                            ChatModels = new ObservableCollection<ChatModel>(chatsItemModelsTwo);
                        }
                    }
                }));
            return disposable;
        }
        
        public async Task OpenChatMethod(ChatInfoModel chatInfo) 
        {
            IsEnabled = false;
            var setchatrepository = chatsRepositories.Where(item => chatInfo.WorkerID == item.WorkerID).FirstOrDefault();
            var getChat = ChatModels.Where(item => chatInfo.WorkerID == item.Info.WorkerID).FirstOrDefault();
            RemoveGrennPoint(getChat);
            //await Application.Current.MainPage.Navigation.PushAsync(new ChatPage(ItemTapped.Chat, setchatrepository));
            var chatPage = new ChatPage(chatInfo, setchatrepository);
            await Application.Current.MainPage.Navigation.PushAsync(chatPage);
            var getIndex = ChatModels.IndexOf(getChat);
            /*var get = */await chatPage.ClosedTask;
            ChatModels[getIndex].MessagesListener = DefineSockets(setchatrepository.Key, setchatrepository.WorkerID);
            IsEnabled = true;
            //ActivateSockets(get);
        }

        public void RemoveGrennPoint(ChatModel chatItemModel) 
        {
            int index = ChatModels.IndexOf(chatItemModel);
            ChatModels[index].IsVisible = false;
            ChatModels[index].MessagesListener.Dispose();
            ChatModels = new ObservableCollection<ChatModel>(ChatModels);
            /*foreach(var chatsSocketModel in ChatModels) 
            {
                chatsSocketModel.MessagesListener.Dispose();
            }*/
        }

        public async Task DeleteChat(ChatInfoModel chatInformationModel) 
        {
            IsEnabled = false;
            var chatRegisterModel = chatRegisterModels.Where(item => item.UserID == $"{chatInformationModel.WorkerID}").FirstOrDefault();
            await App.FirebaseRTDBService.DeleteChat($"{ClientRepository.CountryCode}/{ClientRepository.ClientID}", chatRegisterModel);
            
            var getIndexChatSocketModel = ChatModels.IndexOf(ChatModels.Where(item => item.Info.WorkerID == chatInformationModel.WorkerID).FirstOrDefault());
            ChatModels[getIndexChatSocketModel].MessagesListener.Dispose();
            ChatModels.Remove(ChatModels[getIndexChatSocketModel]);
            
            var getChatItemModel = ChatModels.Where(item => item.Info.WorkerID == chatInformationModel.WorkerID).FirstOrDefault();
            ChatModels.Remove(getChatItemModel);
            
            var getChatRepository = chatsRepositories.Where(item => item.WorkerID == chatInformationModel.WorkerID).FirstOrDefault();
            await App.Database.DeleteChatRepositoryAsync(getChatRepository);

            ChatModels = new ObservableCollection<ChatModel>(ChatModels);
            IsEnabled = true;
        }

        public async Task OpenWorkerProfileMethod(string Id) 
        {
            IsEnabled = false;
            var getInfo = ChatModels.Where(item => item.Info.WorkerID == Id).FirstOrDefault().Info;
            var getWorkerInfo =await App.FirebaseRTDBService.GetWorker(getInfo.WorkerID);
            await Application.Current.MainPage.Navigation.PushAsync(new ProfileWorkerPage(getWorkerInfo, false));
            IsEnabled = true;
        }

        #endregion

    }
}
