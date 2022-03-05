using System.Collections.ObjectModel;
using Yepa.Models;
using Yepa.Views.Home;
using Yepa.Views.AccessApp;
using Xamarin.Forms;
using System;
using Yepa.Helpers;
using Com.OneSignal;
using Rg.Plugins.Popup.Services;
using Yepa.Views.Popup;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;

namespace Yepa.ViewModels 
{
    public class SettingsViewModel : BaseViewModel 
    {

        #region Constructor

        public SettingsViewModel(ClientRepository _clientRepository) 
        {
            IsEnabled = true;
            clientRepository = _clientRepository ?? new ClientRepository();
            ListSettings = GetCategories();
        }

        #endregion


        #region Attributes

        readonly ClientRepository clientRepository = new ClientRepository();
        bool isenabled;

        #endregion


        #region Properties

        public ObservableCollection<SettingsModel> ListSettings { get; private set; }
        
        public bool IsEnabled 
        {
            get { return isenabled; }
            set { SetValue(ref isenabled, value); }
        }

        #endregion


        #region Commands
        
        public ICommand SelectOptionCommand
        {
            get{ return new RelayCommand<SettingsModel>(async selectOption => await SelectOptionMethod(selectOption)); }
        }
        
        #endregion


        #region Methods

        private async Task SelectOptionMethod(SettingsModel selectOption)
        {
            IsEnabled = false;
            switch (selectOption.Key)
            {
                case 1:
                    if (CheckCanUpdateMethod()) 
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new EditProfilePage(new UserInfoModel 
                        {
                            FirstName = clientRepository.FirstName,
                            LastName = clientRepository.LastName,
                            PhoneNumber = clientRepository.PhoneNumber,
                            ModificationDate = clientRepository.ModificationDate,
                        }));
                    }
                    else 
                    {
                        await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, "Sólo puedes cambiar tu información cada 60 días", Languages.Ok, null));
                    }
                    break;
                case 2:
                    await Application.Current.MainPage.Navigation.PushAsync(new PreferencesPage(clientRepository));
                    break;
                case 3:
                    await Application.Current.MainPage.Navigation.PushAsync(new HelpPage());
                    break;
                case 4:
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, "Share", Languages.Ok, null));
                    break;
                case 5:
                    await LogOutMethod();
                    break;
                default:
                    break;
                }
            IsEnabled = true;
        }

        private async Task LogOutMethod()
        {
            await App.FirebaseAuthService.LogOutAsync();
            OneSignal.Current.RemoveExternalUserId();
            Application.Current.MainPage = new NavigationPage(new LogInPage());
        }

        private bool CheckCanUpdateMethod() 
        {
            DateTime TimeNow = DateTime.Now;
            TimeNow = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day);
            var TimeCreate = new DateTime(clientRepository.CreationDate.Year, clientRepository.CreationDate.Month, clientRepository.CreationDate.Day);
            TimeSpan Diff_Time = TimeCreate.Subtract(TimeNow);
            if (Diff_Time.TotalDays > 60) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        private ObservableCollection<SettingsModel> GetCategories() 
        {
            var categories = new ObservableCollection<SettingsModel>() 
            {
                new SettingsModel(1,Languages.Editprofile,FontFontello.Icon_Edit),
                new SettingsModel(2,"Preferences",FontFontello.Icon_Preferences),
                new SettingsModel(3,"Help",FontFontello.Icon_Help),
                new SettingsModel(4,"Share",FontFontello.Icon_Share),
                new SettingsModel(5,Languages.Logout,FontFontello.Icon_LogOut),
            };
            return categories;
        }

        #endregion

    }
}
