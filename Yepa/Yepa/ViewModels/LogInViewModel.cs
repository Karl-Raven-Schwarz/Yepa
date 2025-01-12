using GalaSoft.MvvmLight.Command;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Yepa.Models;
using Yepa.Views;
using Yepa.Services;
using Yepa.Helpers;
using Yepa.Views.AccessApp;
using Com.OneSignal;
using Rg.Plugins.Popup.Services;
using Yepa.Views.Popup;
using System.Collections.ObjectModel;

namespace Yepa.ViewModels 
{
    public class LogInViewModel : BaseViewModel 
    {

        #region Constructor

        public LogInViewModel() 
        {
            IsEnabled = true;
            IsLoading = false;
            if (Preferences.Get("byToken",false))
            {
                _ = LogInWithTokenMethod();
            }
        }

        #endregion


        #region Attribute

        ClientModel clientModel = new ClientModel();
        string email;
        string password;
        bool isLoading;
        bool isEnabled;

        #endregion


        #region Properties

        public ClientModel ClientModel {
            get { return clientModel; }
            set { SetValue(ref clientModel, value); }
        }

        public string Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsEnabled {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public bool IsLoading {
            get { return this.isLoading; }
            set { SetValue(ref this.isLoading, value); }
        }

        #endregion


        #region Commands

        public ICommand ForgotPasswordCommand 
        {
            get { return new RelayCommand(ForgotPasswordMethod); }
        }

        public ICommand LogInCommand 
        {
            get{ return new RelayCommand(async () => await LogInMethod()); }
        }

        public ICommand SignUpCommand 
        {
            get { return new RelayCommand(async () => await SignUpMethod()); }
        }

        public ICommand SendPasswordResetEmailCommand
        {
            get { return new RelayCommand(async () => await SendPasswordResetEmailMethod()); }
        }

        #endregion


        #region Methods

        private void ForgotPasswordMethod() {
            IsLoading = true;
            IsEnabled = false;
            Application.Current.MainPage.Navigation.PushAsync(new FindAccountPage());
            IsLoading = false;
            IsEnabled = true;
        }

        private async Task LogInMethod() 
        {
            IsEnabled = false;
            if (string.IsNullOrEmpty(Email)) {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, Languages.EmailError, Languages.Accept, null));
                this.IsEnabled = true;
                return; }

            if (string.IsNullOrEmpty(Password)) {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, Languages.PasswordError, Languages.Accept, null));
                this.IsEnabled = true;
                return; 
            }
            IsLoading = true;

            try 
            {
                bool isCompleted = await App.FirebaseAuthService.LogInWithEmailAndPasswordAsync(Email.Trim(), Password.Trim());
                if (isCompleted) 
                {
                    var clientRepository = new ClientRepository();
                    string getID = Preferences.Get("ClientID", string.Empty);
                    clientRepository = await App.Database.GetClientRepositoryAsync(getID);
                    if (clientRepository == null) 
                    {
                        ClientModel.Info = await App.FirebaseRTDBService.GetClientIrformation(getID);
                        clientRepository = new ClientRepository(0, getID, OSAppTheme.Light, ClientModel.Info);
                    }
                    else 
                    {

                        if (DateTime.Now.Subtract(clientRepository.ModificationDate).TotalDays > 60)
                        {
                            var getModificationDate = await App.FirebaseRTDBService.GetClientModificationDate(getID);
                            if (clientRepository.ModificationDate != getModificationDate)
                            {
                                ClientModel.Info.SimpleInfo = await App.FirebaseRTDBService.GetClientProfileData(getID);
                            }
                            ClientModel.Info = new ClientInfoModel
                            {
                                Location = new LocationModel(),
                                SimpleInfo = new UserInfoModel(clientRepository.FirstName, clientRepository.LastName, clientRepository.PhoneNumber, clientRepository.ModificationDate),
                                StaticInfo = new StaticClientInfo(clientRepository.Email, clientRepository.CountryCode, clientRepository.CreationDate)
                            };
                        }
                        else 
                        { 
                            ClientModel.Info = new ClientInfoModel {
                                Location = new LocationModel(), 
                                SimpleInfo = new UserInfoModel(clientRepository.FirstName, clientRepository.LastName, clientRepository.PhoneNumber, clientRepository.ModificationDate), 
                                StaticInfo = new StaticClientInfo(clientRepository.Email, clientRepository.CountryCode, clientRepository.CreationDate)
                            };
                        }
                        ClientModel.Chats = new ObservableCollection<ChatRegisterModel>() ?? new ObservableCollection<ChatRegisterModel>();
                        clientRepository = new ClientRepository(clientRepository.ID, getID, clientRepository.Theme, ClientModel.Info);
                    }

                    SetTheme(clientRepository.Theme);
                    Preferences.Set("byToken", true);
                    await App.Database.SaveClientRepositoryAsync(clientRepository);

                    OneSignal.Current.SetExternalUserId(getID, OneSignalService.OneSignalSetExternalUserId);
                    OneSignal.Current.SetExternalUserId(getID);

                    Preferences.Set("LoggedIn", true);

                    await App.FirebaseRTDBService.SetConnection(true, clientRepository.ClientID);

                    Application.Current.MainPage = new NavigationPage(new ContainerTabbedPage(clientRepository, ClientModel.Chats));
                }
                else 
                {
                    return;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, Languages.Invalidlogin, Languages.Ok, null));
            }
            finally 
            {
                IsLoading = false;
                IsEnabled = true;
            }
        }

        private async Task LogInWithTokenMethod() 
        {
            try
            {
                bool isCompleted = await App.FirebaseAuthService.LogInWithFirebaseAuthTokenAsync();
                if (isCompleted)
                {
                    var clientRepository = new ClientRepository();
                    string getID = Preferences.Get("ClientID", string.Empty);
                    clientRepository = await App.Database.GetClientRepositoryAsync(getID);
                    if (clientRepository == null)
                    {
                        ClientModel.Info = await App.FirebaseRTDBService.GetClientIrformation(getID);
                        clientRepository = new ClientRepository(0, getID, OSAppTheme.Light, ClientModel.Info);
                    }
                    else
                    {
                        if (DateTime.Now.Subtract(clientRepository.ModificationDate).TotalDays > 60)
                        {
                            var getModificationDate = await App.FirebaseRTDBService.GetClientModificationDate(getID);
                            if (clientRepository.ModificationDate != getModificationDate)
                            {
                                ClientModel.Info.SimpleInfo = await App.FirebaseRTDBService.GetClientProfileData(getID);
                            }
                            ClientModel.Info = new ClientInfoModel
                            {
                                Location = new LocationModel(),
                                SimpleInfo = new UserInfoModel(clientRepository.FirstName, clientRepository.LastName, clientRepository.PhoneNumber, clientRepository.ModificationDate),
                                StaticInfo = new StaticClientInfo(clientRepository.Email, clientRepository.CountryCode, clientRepository.CreationDate)
                            };
                        }
                        else
                        {
                            ClientModel.Info = new ClientInfoModel
                            {
                                Location = new LocationModel(),
                                SimpleInfo = new UserInfoModel(clientRepository.FirstName, clientRepository.LastName, clientRepository.PhoneNumber, clientRepository.ModificationDate),
                                StaticInfo = new StaticClientInfo(clientRepository.Email, clientRepository.CountryCode, clientRepository.CreationDate)
                            };
                        }
                        ClientModel.Chats = new ObservableCollection<ChatRegisterModel>() ?? new ObservableCollection<ChatRegisterModel>();
                        clientRepository = new ClientRepository(clientRepository.ID, getID, clientRepository.Theme, ClientModel.Info);
                    }
                    SetTheme(clientRepository.Theme);
                    Preferences.Set("byToken", true);
                    await App.Database.SaveClientRepositoryAsync(clientRepository);

                    OneSignal.Current.SetExternalUserId(getID, OneSignalService.OneSignalSetExternalUserId);
                    OneSignal.Current.SetExternalUserId(getID);

                    Preferences.Set("LoggedIn", true);

                    await App.FirebaseRTDBService.SetConnection(true, clientRepository.ClientID);
                    Application.Current.MainPage = new NavigationPage(new ContainerTabbedPage(clientRepository,ClientModel.Chats));

                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {
                Application.Current.MainPage = new NavigationPage(new LogInPage());
            }
            finally
            {
                IsLoading = false;
                IsEnabled = true;
            }
        }
        
        private async Task SignUpMethod(){
            IsLoading = true;
            IsEnabled = false;
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            IsLoading = false;
            IsEnabled = true;
        }

        private async Task SendPasswordResetEmailMethod() 
        {
            IsEnabled = false;
            if (string.IsNullOrEmpty(ClientModel.Info.StaticInfo.Email)) {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, Languages.EmailError, Languages.Accept, null));
                IsEnabled = true;
                return; 
            }
            IsLoading = true;
            try 
            {
                bool isCompleted = await App.FirebaseAuthService.SendPasswordResetEmailAsync(clientModel.Info.StaticInfo.Email);
                if (isCompleted) 
                { 
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    return;
                }  
            }
            catch (Exception ex) {
                Console.WriteLine($"Something is wrong: {ex.Message}");
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Accept, Languages.DataError, Languages.Ok, null));
            }
            finally 
            { 
                IsLoading = false;
                IsEnabled = true;
            }
        }

        private void SetTheme(OSAppTheme theme) 
        {
            switch (theme) 
            {
                case OSAppTheme.Light:
                    Application.Current.UserAppTheme = OSAppTheme.Light;
                    break;
                case OSAppTheme.Dark:
                    Application.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
                default:
                    break;
            }
        }

        #endregion

    }

}