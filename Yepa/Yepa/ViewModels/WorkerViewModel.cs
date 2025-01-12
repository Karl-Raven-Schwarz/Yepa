using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Yepa.Models;
using Yepa.Helpers;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Essentials;
using Yepa.Views.Home;
using Yepa.Views.Popup;
using Rg.Plugins.Popup.Services;
using System.Security.Cryptography;
using Plugin.Toast;

namespace Yepa.ViewModels 
{
    public class WorkerViewModel : BaseViewModel
    {

        #region Constructor

        //PROFILE

        /// <summary>
        /// Constructor to use in worker profile
        /// </summary>
        /// <param name="_workerModel"></param>
        /// <param name="_Pop"></param>
        public WorkerViewModel(WorkerPrincipalData workerPrincipalData, bool pop) 
        {
            IsEnabled = IsLoading = false;
            Pop = pop;
            clientRepository = App.GetClientRepository();
            _ = LoadProfile(workerPrincipalData);
            IsEnabled = true;
        }

        /// <summary>
        /// Contrustor for use in messagesViewModels
        /// </summary>
        /// <param name="workerInfoModel"></param>
        /// <param name="pop"></param>
        public WorkerViewModel(WorkerInfoModel workerInfoModel, bool pop)
        {
            IsEnabled = IsLoading = false;
            Pop = pop;
            clientRepository = App.GetClientRepository();
            LoadProfile(workerInfoModel);
            IsEnabled = true;
        }

        #endregion


        #region Attributes

        ObservableCollection<ChatRegisterModel> chatRegisterModels = new ObservableCollection<ChatRegisterModel>();
        readonly bool Pop;
        ClientRepository clientRepository = new ClientRepository();
        WorkerRepository workerRepository = new WorkerRepository();
        public const double MinimumDistance = 1.5;
        public const double MediumDistance = 3.0;
        public const double MaximunDistance = 5.0;

        ObservableCollection<DataModel> dataProfiles = new ObservableCollection<DataModel>();
        bool isEnabled, isLoading;
        string workerName;
        WorkerInfoModel workerInfo = new WorkerInfoModel();
        string smsmessage;

        #endregion


        #region Properties

        public WorkerInfoModel WorkerInfo 
        {
            get { return workerInfo; }
            set { SetValue(ref workerInfo, value); }
        }

        public ObservableCollection<DataModel> DataProfiles {
            get { return dataProfiles; }
            set { SetValue(ref dataProfiles, value); }
        }

        public bool IsEnabled {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public bool IsLoading{
            get { return this.isLoading; }
            set { SetValue(ref this.isLoading, value); }
        }

        public string WorkerName 
        {
            get { return workerName; }
            set { SetValue(ref workerName, value); }
        }

        public string SMSMessage {
            get { return this.smsmessage; }
            set { SetValue(ref this.smsmessage, value); }
        }

        #endregion


        #region Commands

        
        public ICommand AddWorkerCommand
        {
            get { return new RelayCommand(async ()=> await AddWorkerMethod()); }
        }
        
        public ICommand QualifyCommand 
        {
            get { return new RelayCommand(async () => await QualifyMethod()); }
        }
        
        public ICommand OpenChatCommand 
        {
            get { return new RelayCommand(async () => await OpenChatMethod()); }
        }
        
        public ICommand CallCommmand 
        {
            get { return new RelayCommand(CallMethod); }
        }

        public ICommand SendSMSCommand 
        {
            get { return new RelayCommand(SendSMSMethod); }
        }
        
        public ICommand CopyDataCommand 
        {
            get { return new RelayCommand<string>(ProfileData => CopyDataMethod(ProfileData)); }
        }

        #endregion


        #region Methods

        private async Task AddWorkerMethod()
        {
            await App.Database.SaveWorkerRepositoryAsync(new WorkerRepository(WorkerInfo,Preferences.Get("ClientID",string.Empty)));
        }

        private async Task QualifyMethod() 
        {
            bool register = await App.FirebaseRTDBService.VerifyClientRegisterExistence($"{WorkerInfo.StaticInfo.CountryCode}/{WorkerInfo.StaticInfo.ID}", clientRepository.ClientID);
            if (register) 
            {
                await PopupNavigation.Instance.PushAsync(new RatingPopup());
            }
            else 
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Alert, Languages.CalificationError, Languages.Ok);
                IsEnabled = true;
            }
        }

        private async Task OpenChatMethod() 
        {
            IsLoading = true;
            IsEnabled = false;
            if (Pop)
            {
                await Application.Current.MainPage.Navigation.PopAsync();
            } 
            else 
            {
                bool exist = workerRepository.HaveChat;
                if (!exist)
                {
                    exist = await App.FirebaseRTDBService.VerifyChatExistence(WorkerInfo.StaticInfo.ID, clientRepository.ClientID);
                }
                if (!exist) 
                {
                    Aes aes = Aes.Create();
                    var setDateTime = DateTime.UtcNow;
                    
                    var chat = new ChatModel 
                    {
                        Info = new ChatInfoModel(clientRepository, WorkerInfo,Convert.ToBase64String(aes.Key), setDateTime) 
                    };
                    string Key = await App.FirebaseRTDBService.AddChat(chat.Info);
                    if (!string.IsNullOrEmpty(Key)) 
                    {
                        var chatRepository = new ChatRepository()
                        {
                            Messages_Json = "",
                            Key = Key,
                            AES_Key = Convert.ToBase64String(aes.Key),
                            ClientID = clientRepository.ClientID,
                            ClientName = $"{clientRepository.FirstName} {clientRepository.LastName}",
                            CreationDate = setDateTime,
                            ModificationDate = setDateTime,
                            WorkerID = WorkerInfo.StaticInfo.ID,
                            WorkerName = $"{WorkerInfo.SimpleInfo.FirstName} {WorkerInfo.SimpleInfo.LastName}",
                            LastConnectionClient = setDateTime,
                            LastConnectionWorker = setDateTime,
                        };
                        await App.Database.SaveChatRepositoryAsync(chatRepository);
                        workerRepository.HaveChat = true;
                        await App.Database.SaveWorkerRepositoryAsync(workerRepository);
                        await Application.Current.MainPage.Navigation.PushAsync(new ChatPage(chat.Info, chatRepository));

                        #region NOTIFICATION
                        var content = new NotificationModel.Contents("You have a new chat", "Tienes un nuevo chat");
                        var data = new NotificationModel.Data("bar");
                        var external_user_id = new List<string> { WorkerInfo.StaticInfo.ID };
                        App.OneSignalService.SendNotification(new NotificationModel.Root
                        {
                            include_external_user_ids = external_user_id,
                            app_id = "f17b2e30-33bd-498e-9725-a1d31f1c7823",
                            channel_for_external_user_ids = "push",
                            small_icon = "icon_logo_notification",
                        });
                        #endregion
                    }

                } 
                else 
                {
                    /*
                    var getregister = chatRegisterModels;
                    string getkey = getregister.Where(i => i.UserID == WorkerInfo.StaticInfo.ID).FirstOrDefault().KeyChat;
                    var chatModel = await App.FirebaseRTDBService.GetChatInformation(getkey);
                    var chatrepository = await App.Database.GetChatRepositoryAynsc(WorkerInfo.StaticInfo.ID,clientRepository.ClientID);  
                    await Application.Current.MainPage.Navigation.PushAsync(new ChatPage(new ChatModel(chatModel, getkey), chatrepository));
                    */
                    workerRepository.HaveChat = true;
                    await App.Database.SaveWorkerRepositoryAsync(workerRepository);
                    MessagingCenter.Send(WorkerInfo.StaticInfo.ID, "OpenChat");
                } 
            }
            IsEnabled = true;
            IsLoading = false;
        }

        private async Task LoadProfile(WorkerPrincipalData workerPrincipalData)
        {
            IsEnabled = false;
            workerRepository = await App.Database.GetWorkerRepositoryAsync(workerPrincipalData.ID, clientRepository.ClientID);
            if (workerRepository == null || workerRepository == new WorkerRepository() || DateTime.UtcNow.Subtract(workerRepository.ModificationDate).TotalDays > 60)
            {
                WorkerInfo = await App.FirebaseRTDBService.GetWorker(workerPrincipalData.ID);
                await App.Database.SaveWorkerRepositoryAsync(new WorkerRepository(WorkerInfo, clientRepository.ClientID));
                workerRepository = await App.Database.GetWorkerRepositoryAsync(WorkerInfo.StaticInfo.ID, clientRepository.ClientID);
            }
            else
            {
                WorkerInfo = new WorkerInfoModel(workerRepository, workerPrincipalData);
            }
            WorkerName = $"{WorkerInfo.SimpleInfo.FirstName} {WorkerInfo.SimpleInfo.LastName}";
            DataProfiles = new ObservableCollection<DataModel>
            {
                new DataModel() { Icon = FontFontello.Icon_InfoProfile, TypeData = Languages.Name,Data = $"{WorkerInfo.SimpleInfo.FirstName} {WorkerInfo.SimpleInfo.LastName}" },
                new DataModel() { Icon = FontFontello.Icon_Email, TypeData = Languages.Email, Data = WorkerInfo.StaticInfo.Email },
                new DataModel() { Icon = FontFontello.Icon_Phone, TypeData = Languages.Password, Data = WorkerInfo.SimpleInfo.PhoneNumber },
            };
            clientRepository = await App.Database.GetClientRepositoryAsync(Preferences.Get("ClientID", string.Empty));
            IsEnabled = true;
        }

        private void LoadProfile(WorkerInfoModel workerInfoModel)
        {
            IsEnabled = false;
            WorkerInfo = workerInfoModel;
            workerRepository = new WorkerRepository(WorkerInfo,clientRepository.ClientID);
            WorkerName = $"{WorkerInfo.SimpleInfo.FirstName} {WorkerInfo.SimpleInfo.LastName}";
            DataProfiles = new ObservableCollection<DataModel>
            {
                new DataModel() { Icon = FontFontello.Icon_InfoProfile, TypeData = Languages.Name,Data = $"{WorkerInfo.SimpleInfo.FirstName} {WorkerInfo.SimpleInfo.LastName}" },
                new DataModel() { Icon = FontFontello.Icon_Email, TypeData = Languages.Email, Data = WorkerInfo.StaticInfo.Email },
                new DataModel() { Icon = FontFontello.Icon_Phone, TypeData = Languages.Password, Data = WorkerInfo.SimpleInfo.PhoneNumber },
            };
            IsEnabled = true;
        }

        /*
        private void SetRatingValueMethod(string Value) 
        {
            IsEnabled = false;
            ratingComp = true;
            switch (Value) 
            {
                case "1":
                    Rating = 1.0;
                    Star1 = "#FEB536";
                    Star5 = Star2 = Star3 = Star4 = "#9B9B9B";
                    break;
                case "2":
                    Rating = 2.0;
                    Star1 =Star2= "#FEB536";
                    Star5 = Star3 = Star4 = "#9B9B9B";
                    break;
                case "3":
                    Rating = 3.0;
                    Star1 = Star2 = Star3 = "#FEB536";
                    Star5 = Star4 = "#9B9B9B";
                    break;
                case "4":
                    Rating = 4.0;
                    Star1 = Star2 = Star3 = Star4 = "#FEB536";
                    Star5 = "#9B9B9B";
                    break;
                case "5":
                    Rating = 5.0;
                    Star1 = Star2 = Star3 = Star4 = Star5 = "#FEB536";
                    break;
                default:
                    ratingComp = false;
                    break;
                }
            IsEnabled = true;
        }
        */

        private void CallMethod() 
        {
            try 
            {
                PhoneDialer.Open("+"+WorkerInfo.SimpleInfo.PhoneNumber);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
                PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, "Ha ocurrido un error. Vuelva a intentarlo", Languages.Ok));
            }
        }

        private void SendSMSMethod() 
        {
            IsEnabled = false;
            try 
            {
                 Sms.ComposeAsync(new SmsMessage(null, WorkerInfo.SimpleInfo.PhoneNumber));
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
                 PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, "Ha ocurrido un error. Vuelva a intentarlo", Languages.Ok));
            }
            IsEnabled = true;
        }

        private void CopyDataMethod(string ProfileData) 
        {
            Clipboard.SetTextAsync(ProfileData);
            CrossToastPopUp.Current.ShowToastSuccess("Copied");
        }

        #endregion
    }
}
