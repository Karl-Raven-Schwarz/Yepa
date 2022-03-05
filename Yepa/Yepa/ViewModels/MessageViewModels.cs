using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Yepa.Models;
using Yepa.Views.Home;
using Xamarin.Forms;
using System;
using Yepa.Helpers;
using System.Linq;
using Yepa.Views.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using System.Security.Cryptography;
using System.Reactive.Linq;

/*
System.Diagnostics.Stopwatch timeMeasure = new System.Diagnostics.Stopwatch();
timeMeasure.Start();

timeMeasure.Stop();
await App.Current.MainPage.DisplayAlert(null,$"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms","ok");
 */

namespace Yepa.ViewModels 
{
    public class MessageViewModels : BaseViewModel 
    {

        #region Constructor    

        public MessageViewModels(ChatInfoModel _chatInfo , ChatRepository _chatRepository) 
        {
            ChatInfo = _chatInfo;
            chatRepository = _chatRepository;
            HasBackButton = true;
            FontSize = Preferences.Get("FontSize", 16);
            TimeFontSize = Convert.ToInt32(.75 * FontSize);
            CornerRadius = 10;
            _ = LoadWorkerProfile();
            _ = LoadData();
            LoadConnected();
        }

        public MessageViewModels(MessageModel messageModel) 
        {
            messageModel.CreationDate = messageModel.CreationDate.ToLocalTime();
            DataMessage = new ObservableCollection<DataModel> 
            {
                new DataModel(){TypeData = Languages.Username, Data = messageModel.CreationDate.ToString("ddd, dd MMM HH:mm")},
                new DataModel(){TypeData = Languages.Email, Data = messageModel.Message },
            };
        }

        #endregion


        #region Destructor    

        public async Task Destroy() 
        {
            SocketChatConnected?.Dispose();
            SocketMessages?.Dispose();
            SocketWorkerConnected?.Dispose();
            await App.FirebaseRTDBService.SetLastConnectionClient(chatRepository.LastConnectionClient, chatRepository.Key);
            await App.Database.SaveChatRepositoryAsync(chatRepository);
        }

        #endregion


        #region Attributes
        
        readonly AesEncrypterHelper AesEncrypterHelper = new AesEncrypterHelper();
        readonly ChatRepository chatRepository = new ChatRepository();
        WorkerRepository WorkerRepository = new WorkerRepository();
        ClientRepository clientRepository = new ClientRepository();
        IDisposable SocketMessages, SocketWorkerConnected, SocketChatConnected;
        readonly NotificationModel.Root NotificationModel = new NotificationModel.Root {
            app_id = "f17b2e30-33bd-498e-9725-a1d31f1c7823",
            channel_for_external_user_ids = "push",
            small_icon = "icon_logo_notification",
        };
        readonly Aes Aes = Aes.Create();


        public ObservableCollection<MessageModel> messageModels = new ObservableCollection<MessageModel>();
        public ObservableCollection<DataModel> dataMessage = new ObservableCollection<DataModel>();
        ChatInfoModel chatInfo;
        private string message;
        private string connectionState = string.Empty;
        private bool isEnabled, hasBackButton;
        private bool WorkerConnected;
        private int fontSize, timeFontSize;
        private int UnreadMessages = 0, cornerRadius;

        #endregion


        #region Properties

        public ObservableCollection<MessageModel> MessageModels {
            get { return messageModels; }
            set { SetValue(ref this.messageModels, value); }
        }

        public ObservableCollection<DataModel> DataMessage {
            get { return dataMessage; }
            set { SetValue(ref this.dataMessage, value); }
        }

        public ChatInfoModel ChatInfo 
        {
            get { return chatInfo; }
            set { SetValue(ref chatInfo, value); }
        }
        
        public int CornerRadius
        {
            get { return cornerRadius; }
            set { SetValue(ref cornerRadius, value); }
        }

        public int FontSize {
            get { return this.fontSize; }
            set { SetValue(ref this.fontSize, value); }
        }

        public int TimeFontSize {
            get { return this.timeFontSize; }
            set { SetValue(ref this.timeFontSize, value); }
        }

        public bool IsEnabled {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public string Message {
            get { return this.message; }
            set { SetValue(ref this.message, value); }
        }

        public string ConnectionState {
            get { return this.connectionState; }
            set { SetValue(ref this.connectionState, value); }
        }

        public bool HasBackButton {
            get { return this.hasBackButton; }
            set { SetValue(ref this.hasBackButton, value); }
        }

        #endregion


        #region Commands

        public ICommand SendMessageCommand 
        {
            get { return new RelayCommand(async () => await SendMessageMethod()); }
        }

        public ICommand OpenWorkerProfileCommand 
        {
            get { return new RelayCommand(OpenWorkerProfileMethod); }
        }

        public ICommand CallCommand 
        {
            get { return new RelayCommand(async () => await CallMethod()); }
        }

        public ICommand MessageLongPressedCommand 
        {
            get { return new RelayCommand<MessageModel>(async x => await MessageLongPressedMethod(x)); }
        }

        public ICommand MessageShortPressedCommand 
        {
            get { return new RelayCommand<string>((x) => MessageShortPressedMethod(x)); }
        }

        public ICommand CloseCommand
        {
            get { return new RelayCommand(async () => await Destroy()); }
        }

        #endregion


        #region Methods

        private async Task CallMethod() 
        {
            var options = new string[] { 
                $"Normal : { WorkerRepository.PhoneNumber }", 
                $"Telegram : {WorkerRepository.PhoneNumber}", 
                $"Whatsapp : {WorkerRepository.PhoneNumber}" };
            await PopupHelper.ActionSheetPopup("Call :", "Cancel", options);
        }

        private async Task SendMessageMethod() 
        {
            IsEnabled = false;

            #region Label Error

            if (message != null) {
                message = message.Trim();
            }

            if (string.IsNullOrEmpty(this.message)) {
                this.IsEnabled = true;
                return;
            }

            #endregion

            this.IsEnabled = true;
            var setCreationDate = DateTime.Now.ToUniversalTime().AddSeconds(2.0);
            var getMessage = Message;
            Message = string.Empty;
            MessageModels.Add(new MessageModel(getMessage, 0, setCreationDate));
            await App.FirebaseRTDBService.AddMessage(new MessageModel(SetMessageEncrypter(getMessage), 0, setCreationDate), chatRepository.Key);
            await App.Database.SaveMessageRepositoryAsync(new MessageRepository(new MessageModel(SetMessageEncrypter(getMessage), 0, setCreationDate), chatRepository.Key));

            if (!WorkerConnected) 
            {
                var content = new NotificationModel.Contents();
                var data = new NotificationModel.Data();
                var external_user_id = new List<string>();

                if (UnreadMessages == 1) 
                {
                    external_user_id.Add(WorkerRepository.WorkerID);
                    content.en = "You have a new message";
                    content.es = "Tienes un nuevo mensage";
                    data.foo = "bar";

                    NotificationModel.include_external_user_ids = external_user_id;
                    NotificationModel.data = data;
                    NotificationModel.contents = content;

                    App.OneSignalService.SendNotification(NotificationModel);
                }
                else if (UnreadMessages % 5 == 0) 
                {
                    external_user_id.Add(WorkerRepository.WorkerID);
                    content.en = "You have new messages";
                    content.es = "Tienes nuevos mensages";
                    data.foo = "bar";

                    NotificationModel.include_external_user_ids = external_user_id;
                    NotificationModel.data = data;
                    NotificationModel.contents = content;

                    App.OneSignalService.SendNotification(NotificationModel);
                }
            }
        }

        private int GetUnreadMessages() 
        {
            int lower = 0, upper = MessageModels.Count - 1, center = ((upper + lower) / 2);
            while (lower <= upper) 
            {
                if (MessageModels[center].CreationDate == chatRepository.LastConnectionWorker
                    && MessageModels[center].CreationDate.Second == chatRepository.LastConnectionWorker.Second) 
                {
                    return MessageModels.Count - center - 1;
                }
                else if (chatRepository.LastConnectionWorker < MessageModels[center].CreationDate) 
                {
                    upper = center - 1;
                }
                else 
                {
                    lower = center + 1; 
                }
                center = ((upper + lower) / 2);
            }
            return MessageModels.Count - upper - 1;
        }

        async Task LoadData()
        {
            try 
            { 
                Aes.Key = Convert.FromBase64String(ChatInfo.AES_Key);
                Aes.IV = new byte[] { 156, 113, 196, 36, 37, 155, 111, 137, 34, 61, 147, 172, 215, 5, 5, 136 };
                if (chatRepository.ModificationDate > ChatInfo.CreationDate)
                {
                    MessageModels = new ObservableCollection<MessageModel>((await App.Database.GetAllMessagesRepositoryFromChatAsync(chatRepository.Key))
                        .Distinct(new MessageModel()).Select(mess => new MessageModel(GetMessageEncrypter(mess.Message), mess.Colum, mess.CreationDate))
                        .ToList()) ?? new ObservableCollection<MessageModel>();
                    await App.Database.SaveChatRepositoryAsync(chatRepository);
                }

                SocketMessages = App.FirebaseRTDBService.FirebaseClient.Child($"Chats/{chatRepository.Key}/Messages")
                    .AsObservable<MessageModel>().Subscribe(async item =>
                    {
                        if (item.EventType == 0)
                        {
                            var message = new MessageModel();
                            if (item.Object.Colum != 1)
                            {
                                message = new MessageModel(GetMessageEncrypter(item.Object.Message), item.Object.Colum, item.Object.CreationDate);
                            }
                            else
                            {
                                message = new MessageModel(string.Empty, item.Object.Colum, item.Object.CreationDate);
                            }

                            if (!MessageModels.Any(p => p.CreationDate == message.CreationDate && p.Message == message.Message
                                                    && p.CreationDate.Second == message.CreationDate.Second))
                            {
                                MessageModels.Add(message);
                                await App.Database.SaveMessageRepositoryAsync(new MessageRepository(message, chatRepository.Key));
                            }
                        }
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
            }
        }

        string GetMessageEncrypter(string message) 
        {
            try 
            {
                using (Aes myAes = Aes.Create()) 
                {
                    myAes.Key = Aes.Key;
                    myAes.IV = Aes.IV;
                    message = AesEncrypterHelper.DecryptStringFromBytes_Aes(Convert.FromBase64String(message), Aes.Key, Aes.IV);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return message;
        }

        string SetMessageEncrypter(string message) 
        {
            try 
            {
                using (Aes myAes = Aes.Create()) 
                {
                    myAes.Key = Aes.Key;
                    myAes.IV = Aes.IV;
                    byte[] messageEncrypter = AesEncrypterHelper.EncryptStringToBytes_Aes(message, Aes.Key, Aes.IV);
                    message = Convert.ToBase64String(messageEncrypter);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return message;
        }

        private void LoadConnected() 
        {
            SocketWorkerConnected = App.FirebaseRTDBService.FirebaseClient.Child($"Workers/{ChatInfo.WorkerID}/Connection")
                .AsObservable<bool>().Subscribe(item => 
                {
                    WorkerConnected = item.Object;
                    if (item.Object) 
                    {
                        ConnectionState = "Conectado";
                    }
                    else 
                    {
                        var get = chatRepository.LastConnectionWorker;
                        ConnectionState = "Desconectado" + get.ToLocalTime();
                    }
                });

            SocketChatConnected = App.FirebaseRTDBService.FirebaseClient.Child($"Chats/{chatRepository.Key}/Connection")
                .AsObservable<DateTime>().Subscribe(item => 
                {
                    switch (item.Key) 
                    {
                        case "LastConnectionWorker":
                            chatRepository.LastConnectionWorker = item.Object;
                            UnreadMessages = GetUnreadMessages();
                            break;
                        case "ModificationDate":
                            chatRepository.ModificationDate = item.Object;
                            break;
                        case "LastConnectionClient":
                            chatRepository.LastConnectionClient = item.Object;
                            break;
                        default:
                            break;
                    }
                });
        }

        private async Task LoadWorkerProfile() 
        {
            WorkerRepository = await App.Database.GetWorkerRepositoryAsync(chatRepository.WorkerID, chatRepository.ClientID);
            if (WorkerRepository == null) 
            {
                var getWorker = await App.FirebaseRTDBService.GetWorker(ChatInfo.WorkerID);
                WorkerRepository = new WorkerRepository(getWorker, chatRepository.ClientID);
                await App.Database.SaveWorkerRepositoryAsync(WorkerRepository);
            }
        }

        private async void OpenWorkerProfileMethod() 
        {
            var getWorkerModel = await App.FirebaseRTDBService.GetWorker(ChatInfo.WorkerID);
            await Application.Current.MainPage.Navigation.PushAsync(new ProfileWorkerPage(getWorkerModel, true));
        }

        private async Task MessageLongPressedMethod(MessageModel getMessageModel) 
        {
            await PopupNavigation.Instance.PushAsync(new MessageSelectedPopup(getMessageModel));
        }

        private async void MessageShortPressedMethod(string message) {
            HasBackButton = false;
            await Application.Current.MainPage.DisplayAlert("tite", message, "ok");
            await Task.Delay(3000);
            HasBackButton = true;
            /*
            ObservableCollection<GroupDataModel> options = new ObservableCollection<GroupDataModel>();
            var Data = new GroupDataModel();
            foreach (Match item in Regex.Matches(message, LinksPatern, RegexOptions.Compiled | RegexOptions.IgnoreCase)) {
                Data.Add(new DataModel { Data = item.Value, Key = 1 });
            }
            if (Data.Count > 0){
                Data.Title = "Ir a:";
                options.Add(Data);
                Data = new GroupDataModel();
            }
            foreach (Match item in Regex.Matches(message, PhoneNumberPatern, RegexOptions.Compiled | RegexOptions.IgnoreCase)){
                Data.Add(new DataModel { Data = item.Value, Key = 2 });
            }
            if (Data.Count > 0){
                Data.Title = "Llamar a:";
                options.Add(Data);
                Data = new GroupDataModel();
            }
            foreach (Match item in Regex.Matches(message, EmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase)){
                Data.Add(new DataModel { Data = item.Value, Key = 3 });
            }
            if (Data.Count > 0){
                Data.Title = "Enviar email a:";
                options.Add(Data);
            }
            if (options.Count > 0){
                
            }*/
        }

        #endregion

    }

}


