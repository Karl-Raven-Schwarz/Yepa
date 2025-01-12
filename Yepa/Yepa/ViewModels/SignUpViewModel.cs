using Com.OneSignal;
using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Yepa.Helpers;
using Yepa.Models;
using Yepa.Services;
using Yepa.Views.Popup;

namespace Yepa.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {

        #region Constructor

        public SignUpViewModel()
        {
            IsEnabled = true;
            IsLoading = false;
            CountryModels = CountryModel.GetCountries();
            GetCountry();
        }

        #endregion


        #region Attributes

        string email;
        string password;
        string confirmPassword;
        string phoneNumber;
        bool isLoading;
        bool isEnabled;
        bool isCheked;
        ClientInfoModel clientProfile = new ClientInfoModel();
        CountryModel countryModelCountry;
        CountryModel countryModelPhone;
        readonly ObservableCollection<CountryModel> CountryModels = new ObservableCollection<CountryModel>();

        #endregion


        #region Properties

        public ClientInfoModel ClientProfile
        {
            get { return clientProfile; }
            set { SetValue(ref clientProfile, value); }
        }

        public CountryModel CountryModelCountry
        {
            get { return countryModelCountry; }
            set { SetValue(ref countryModelCountry, value); }
        }

        public CountryModel CountryModelPhone
        {
            get { return countryModelPhone; }
            set { SetValue(ref countryModelPhone, value); }
        }

        public string Email
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { SetValue(ref confirmPassword, value); }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetValue(ref phoneNumber, value); }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public bool IsLoading
        {
            get { return isLoading; }
            set { SetValue(ref isLoading, value); }
        }

        public bool IsCheked
        {
            get { return isCheked; }
            set { SetValue(ref isCheked, value); }
        }

        #endregion


        #region Commands

        public ICommand SignUpCommand
        {
            get { return new Command(async _ => await SignUpMethod()); }
        }

        public ICommand LogInCommand
        {
            get { return new RelayCommand(NavToLoginMethod); }
        }

        public ICommand GetCountryCodeCommand
        {
            get { return new Command(async _ => await GetCountryCodeMethod()); }
        }

        public ICommand GetPhoneCodeCommand
        {
            get { return new Command(async _ => await GetPhoneCodeMethod()); }
        }

        #endregion


        #region Methods

        private async Task SignUpMethod()
        {
            IsEnabled = false;

            #region Label Error

            if (string.IsNullOrEmpty(Email))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.EmailError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.PasswordError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(ClientProfile.SimpleInfo.FirstName))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.FirstnameError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(ClientProfile.SimpleInfo.LastName))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LastnameError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, "Debe ingresar un número de teléfono", Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (!IsCheked)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LocationError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            #endregion

            IsLoading = true;

            try
            {
                bool isCompleted = await App.FirebaseAuthService.SignUpWithEmailAndPasswordAsync(email.Trim(), password, $"{ClientProfile.SimpleInfo.FirstName.TrimEnd().TrimStart()} {ClientProfile.SimpleInfo.LastName.TrimEnd().TrimStart()}");
                if (isCompleted)
                {
                    ClientProfile.StaticInfo.CreationDate = DateTime.Now.ToUniversalTime();
                    var getID = Preferences.Get("ClientID", string.Empty);
                    if (getID != null && getID != string.Empty)
                    {
                        //Set UserID in OneSignal
                        OneSignal.Current.SetExternalUserId(getID, OneSignalService.OneSignalSetExternalUserId);

                        ClientProfile.SimpleInfo.PhoneNumber = $"{CountryModelPhone} {PhoneNumber}";
                        await App.FirebaseRTDBService.AddClient(ClientProfile, getID);
                    }
                }
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Accept, Languages.DataError, Languages.Ok, null));
            }
            finally
            {
                this.IsLoading = false;
                this.IsEnabled = true;
            }

        }

        private void NavToLoginMethod()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        public void GetCountry()
        {
            try
            {
                var country = DependencyService.Get<Interfaces.IPhoneNumberService>().GetNetworkCountryIso();
                if (country == null || country == "")
                {
                    country = DependencyService.Get<Interfaces.IPhoneNumberService>().GetSimCountryIso();
                }
                if (country == null || country == "")
                {
                    country = RegionInfo.CurrentRegion.ToString();
                }
                if (country == null || country == "")
                {
                    country = "US";
                }
                var getCountryModel = CountryModels.Where(i => i.Code == country.ToUpperInvariant() || i.Code == country.ToUpper() || i.Code == country).FirstOrDefault();
                CountryModelPhone = CountryModelCountry = getCountryModel;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private async Task GetCountryCodeMethod()
        {
            IsEnabled = false;
            var getCountry = await PopupHelper.CountryPopup();
            CountryModelCountry = getCountry == null || getCountry == new CountryModel() ? CountryModelCountry : getCountry;
            IsEnabled = true;
        }

        private async Task GetPhoneCodeMethod()
        {
            IsEnabled = false;
            var getPhoneCode = await PopupHelper.PhoneCodePopup();
            CountryModelPhone = getPhoneCode == null || getPhoneCode == new CountryModel() ? CountryModelPhone : getPhoneCode;
            IsEnabled = true;
        }

        #endregion

    }

    /// <summary>
    /// Class for tests
    /// </summary>
    public class SignUpViewModelWorker : BaseViewModel
    {

        #region Constructor

        public SignUpViewModelWorker()
        {
            IsEnabled = true;
            IsLoading = false;
            CountryModels = CountryModel.GetCountries();
            GetCountry();
        }

        #endregion


        #region Attributes

        string password, confirmPassword = string.Empty;
        string phoneNumber;
        bool isLoading;
        bool isEnabled;
        bool isCheked = false;
        WorkerInfoModel workerInfoModel = new WorkerInfoModel();
        CountryModel countryModelCountry;
        RegionModel regionModel;
        CountryModel countryModelPhone;
        readonly ObservableCollection<CountryModel> CountryModels = new ObservableCollection<CountryModel>();
        public string category = string.Empty;
        public string subCategory = string.Empty;
        LocationModel myLocation = new LocationModel();

        #endregion


        #region Properties

        public string Category
        {
            get { return category; }
            set { SetValue(ref category, value); }
        }

        public LocationModel MyLocation
        {
            get { return myLocation; }
            set { SetValue(ref myLocation, value); }
        }

        public string SubCategory
        {
            get { return subCategory; }
            set { SetValue(ref subCategory, value); }
        }

        public WorkerInfoModel WorkerInfoModel
        {
            get { return workerInfoModel; }
            set { SetValue(ref workerInfoModel, value); }
        }

        public CountryModel CountryModelCountry
        {
            get { return countryModelCountry; }
            set { SetValue(ref countryModelCountry, value); }
        }

        public RegionModel RegionModel
        {
            get { return regionModel; }
            set { SetValue(ref regionModel, value); }
        }

        public CountryModel CountryModelPhone
        {
            get { return countryModelPhone; }
            set { SetValue(ref countryModelPhone, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetValue(ref phoneNumber, value); }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { SetValue(ref confirmPassword, value); }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public bool IsLoading
        {
            get { return isLoading; }
            set { SetValue(ref isLoading, value); }
        }

        public bool IsCheked
        {
            get { return this.isCheked; }
            set { SetValue(ref this.isCheked, value); }
        }

        #endregion


        #region Commands

        public ICommand SignUpCommand
        {
            get { return new Command(async _ => await SignUpMethod()); }
        }

        public ICommand GetCountryCodeCommand
        {
            get { return new Command(async _ => await GetCountryCodeMethod()); }
        }

        public ICommand GetPhoneCodeCommand
        {
            get { return new RelayCommand(async () => await GetPhoneCodeMethod()); }
        }

        public ICommand GetCategoryCommand
        {
            get { return new RelayCommand(async () => await GetCategoryMethod()); }
        }

        public ICommand GetSubCategoryCommand
        {
            get { return new RelayCommand(async () => await GetSubCategoryMethod()); }
        }

        public ICommand GetLocationCommand
        {
            get { return new RelayCommand(async () => await GetLocationMethod()); }
        }

        #endregion


        #region Methods

        private async Task SignUpMethod()
        {
            IsEnabled = false;

            #region Label Error

            if (string.IsNullOrEmpty(WorkerInfoModel.StaticInfo.Email))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.EmailError, Languages.Accept);
                IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.PasswordError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.PasswordError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, "Password no equal to ComfirmPassword", Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(WorkerInfoModel.SimpleInfo.FirstName))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.FirstnameError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(WorkerInfoModel.SimpleInfo.LastName))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LastnameError, Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, "Debe ingresar un número de teléfono", Languages.Accept);
                this.IsEnabled = true;
                return;
            }

            if (!IsCheked)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LocationError, Languages.Accept);
                IsEnabled = true;
                return;
            }

            #endregion

            IsLoading = true;
            await GetLocationMethod();
            try
            {
                bool isCompleted = await App.FirebaseAuthService.SignUpWorkerWithEmailAndPasswordAsync(WorkerInfoModel.StaticInfo.Email.Trim(), password, $"{WorkerInfoModel.SimpleInfo.FirstName.TrimEnd().TrimStart()} {WorkerInfoModel.SimpleInfo.LastName.TrimEnd().TrimStart()}");
                if (isCompleted)
                {
                    WorkerInfoModel.StaticInfo.CreationDate = DateTime.Now.ToUniversalTime();
                    var getID = Preferences.Get("WorkerID", string.Empty);
                    if (getID != null && getID != string.Empty)
                    {
                        WorkerInfoModel.SimpleInfo.PhoneNumber = $"{CountryModelPhone} {PhoneNumber}";
                        await App.FirebaseRTDBService.AddWorker(WorkerInfoModel, getID);
                    }
                }
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Accept, Languages.DataError, Languages.Ok, null));
            }
            finally
            {
                IsLoading = false;
                IsEnabled = true;
            }
        }

        public void GetCountry()
        {
            try
            {
                var country = DependencyService.Get<Interfaces.IPhoneNumberService>().GetNetworkCountryIso();
                if (country == null || country == "")
                {
                    country = DependencyService.Get<Interfaces.IPhoneNumberService>().GetSimCountryIso();
                }
                if (country == null || country == "")
                {
                    country = RegionInfo.CurrentRegion.ToString();
                }
                if (country == null || country == "")
                {
                    country = "US";
                }
                var getCountryModel = CountryModels.Where(i => i.Code == country.ToUpperInvariant() || i.Code == country.ToUpper() || i.Code == country).FirstOrDefault();
                CountryModelPhone = CountryModelCountry = getCountryModel;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private async Task GetCountryCodeMethod()
        {
            IsEnabled = false;
            CountryModelCountry = await PopupHelper.CountryPopup();
            IsEnabled = true;
        }

        private async Task GetCategoryMethod()
        {
            IsEnabled = false;
            var geCategory = await PopupHelper.CategoryPopup();
            Category = geCategory == string.Empty || geCategory == null ? Category : geCategory;
            CountryModelPhone = new CountryModel
            { 
                Code = CountryModelCountry.Code,
                Name = CountryModelCountry.Name,
                NativeName = CountryModelCountry.NativeName,
                PhoneCode = CountryModelCountry.PhoneCode,
                Regions = CountryModelCountry.Regions,
                PhoneFormat = "XXX XX XX XXXXXXX" 
            };
            IsEnabled = true;
        }

        private async Task GetSubCategoryMethod()
        {
            IsEnabled = false;
            var getSubCategory = await PopupHelper.SubCategoryPopup(Category);
            SubCategory = getSubCategory == string.Empty || getSubCategory == null ? SubCategory : getSubCategory;
            IsEnabled = true;
        }

        private async Task GetPhoneCodeMethod()
        {
            IsEnabled = false;
            CountryModelPhone = await PopupHelper.PhoneCodePopup();
            IsEnabled = true;
        }

        private async Task GetLocationMethod()
        {
            await LocationHelper.Localize();
            MyLocation = new LocationModel(LocationHelper.Placemark.Location);
            LocationHelper.SetArea();
        }

        #endregion
    }
}


