using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Yepa.Helpers;
using Yepa.Models;
using Yepa.Views.Popup;

namespace Yepa.ViewModels 
{
    class PreferencesViewModel : BaseViewModel
    {

        #region Constructor

        public PreferencesViewModel(ClientRepository _clientRepository)
        {
            IsEnabled = true;
            SetCategories();
            clientRepository = _clientRepository ?? new ClientRepository();
            isDark = Application.Current.UserAppTheme == OSAppTheme.Dark;
            SliderFontSize = Preferences.Get("FontSize", 16);
            DateFontSize = Convert.ToInt32(SliderFontSize*.75);
        }

        #endregion


        #region Attributes

        readonly ClientRepository clientRepository = new ClientRepository();
        ObservableCollection<SettingsModel> generalPreferences = new ObservableCollection<SettingsModel>();
        bool isEnabled;
        bool isDark;
        int sliderFontSize, sliderBorder;
        int fontSize,dateFontSize;
        
        #endregion


        #region Properties
        
        public string WokerMessage { get; } = "Hello Mrs. Martha";
        public string ClientMessage { get; } = "Hello Mr. Lucas, I need your help for today";

        public DateTime WorkerDate { get; } = DateTime.Now.ToLocalTime();
        public DateTime ClientDate { get; } = DateTime.Now.AddMinutes(0.5).ToLocalTime();

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public int SliderFontSize
        {
            get { return Convert.ToInt32(sliderFontSize); }
            set {
                DateFontSize = Convert.ToInt32(value * .75);
                FontSize = Convert.ToInt32(value);
                SetValue(ref sliderFontSize, Convert.ToInt32(value)); 
            }
        }

        public int SliderBorder
        {
            get { return Convert.ToInt32(sliderBorder); }
            set { SetValue(ref sliderBorder, Convert.ToInt32(value)); }
        }

        public int FontSize
        {
            get { return fontSize; }
            set { SetValue(ref fontSize, value);  }
        }

        public int DateFontSize
        {
            get { return dateFontSize; }
            set { SetValue(ref dateFontSize, value); }
        }

        public ObservableCollection<SettingsModel> GeneralPreferences 
        {
            get { return generalPreferences; }
            set { SetValue(ref generalPreferences, value); }
        }

        public ObservableCollection<SettingsModel> ChatPreferences { get; private set; } = new ObservableCollection<SettingsModel>();

        #endregion


        #region Commands

        public ICommand SelectOptionCommand
        {
            get { return new RelayCommand<int>(async option => await SelectOptionMethod(option)); }
        }

        public ICommand CloseCommand
        {
            get { return new RelayCommand(async () => await CloseMethod()); }
        }

        #endregion


        #region Methods

        private async Task SelectOptionMethod(int option)
        {
            IsEnabled = false;
            switch (option)
            {
                case 1:
                    await PopupNavigation.Instance.PushAsync(new ChangeFontSizePopup());
                    break;
                case 2:
                    await SetTheme();
                    break;
                case 3:
                    await PopupNavigation.Instance.PushAsync(new ChangeFontSizePopup());
                    break;
                default:
                    break;
            }
            IsEnabled = true;
        }

        private async Task SetTheme() 
        {
            if (isDark)
            {
                Application.Current.UserAppTheme = OSAppTheme.Light;
                clientRepository.Theme = OSAppTheme.Light;
                GeneralPreferences[1] = new SettingsModel(2,"Switch to Dark Theme", FontFontello.Icon_Theme);
                isDark = false;
            }
            else
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
                clientRepository.Theme = OSAppTheme.Dark;
                GeneralPreferences[1] = new SettingsModel(2, "Switch to Light Theme", FontFontello.Icon_Theme);
                isDark = true;
            }
            await App.Database.SaveClientRepositoryAsync(clientRepository);
        }

        public void SetCategories()
        {
            GeneralPreferences = new ObservableCollection<SettingsModel>
            {
                new SettingsModel(1,"Change Chat Background ",FontFontello.Icon_InfoProfile ),
                new SettingsModel(2,isDark == true ? "Switch to Light Theme" : "Switch to Dark Theme",FontFontello.Icon_Theme ),
            };

            ChatPreferences = new ObservableCollection<SettingsModel>
            {
                new SettingsModel(0,"Change Font Size",FontFontello.Icon_FontSize ),
                new SettingsModel(0,"Change Border",FontFontello.Icon_Chat ),
            };
        }

        private async Task CloseMethod()
        {
            await PopupNavigation.Instance.PushAsync(new AlertPopup("ALERT","CLOSING......"));
        }

        #endregion
    }
}

