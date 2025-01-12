using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Yepa.Models;
using Yepa.Helpers;
using Xamarin.Essentials;
using System;
using Xamarin.Forms;
using Yepa.Views.Popup;
using Rg.Plugins.Popup.Services;
using Yepa.Views.Home;
using Plugin.Toast;

namespace Yepa.ViewModels 
{
    public class UserViewModel : BaseViewModel 
    {

        #region Constructor

        public UserViewModel(ClientRepository clientRepository) 
        {
            IsEnabled = true;
            IsLoading = false;
            ClientRepository = clientRepository ?? new ClientRepository();
            _ = LoadData();
            /*
            MessagingCenter.Subscribe<string>(this, "ScrollToLast", (sender1) => {
            ScrollToLastMethod();
            });
            MessagingCenter.Send("" , "ScrollToLast");
            */
        }

        public UserViewModel() 
        {
            IsEnabled = true;
            IsLoading = false;
        }

        public UserViewModel(UserInfoModel userInfoModel) 
        {
            IsEnabled = true;
            IsLoading = false;
            ClientRepository.FirstName = userInfoModel.FirstName ?? ClientRepository.FirstName;
            ClientRepository.LastName = userInfoModel.LastName ?? ClientRepository.LastName;
            ClientRepository.ModificationDate = userInfoModel.ModificationDate == null ? ClientRepository.ModificationDate : userInfoModel.ModificationDate;
            ClientRepository.PhoneNumber = userInfoModel.PhoneNumber ?? ClientRepository.PhoneNumber;
        }

        #endregion


        #region Attributes

        CountryModel countryModelPhone;
        string newPassword;
        ObservableCollection<DataModel> dataProfiles = new ObservableCollection<DataModel>();
        ClientRepository clientRepository = new ClientRepository();
        bool isLoading;
        bool isEnabled;
        int columnsNumber;
        ObservableCollection<WorkerRepository> workerRepositories = new ObservableCollection<WorkerRepository>();

        #endregion


        #region Properties

        public ObservableCollection<WorkerRepository> WorkerRepositories {
            get { return workerRepositories; }
            set { SetValue(ref this.workerRepositories, value); }
        }

        public CountryModel CountryModelPhone {
            get { return countryModelPhone; }
            set { SetValue(ref this.countryModelPhone, value); }
        }

        public ObservableCollection<DataModel> DataProfiles {
            get { return dataProfiles; }
            set { SetValue(ref this.dataProfiles, value); }
        }

        public ClientRepository ClientRepository {
            get { return clientRepository; }
            set { SetValue(ref clientRepository, value); } 
        } 

        public string NewPassword {
            get { return this.newPassword; }
            set { SetValue(ref this.newPassword, value); }
        }

        public bool IsLoading {
            get { return isLoading; }
            set { SetValue(ref this.isLoading, value); }
        }

        public bool IsEnabled {
            get { return isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public int ColumnsNumber {
            get { return columnsNumber; }
            set { SetValue(ref this.columnsNumber, value); }
        }

        #endregion


        #region Commands

        public ICommand UpdateCommand 
        {
            get { return new Command(async _ => await UpdateMethod()); }
        }

        public ICommand ChangePassworCommand
        {
            get { return new Command(async _ => await ChangePasswordMethod()); }
        }

        public ICommand GetPhoneCodeCommand 
        {
            get { return new Command(async _ => await GetPhoneCodeMethod()); }
        }

        public ICommand CopyProfileDataCommand 
        {
            get{ return new RelayCommand<string>(ProfileData => CopyProfileDataMethod(ProfileData)); }
        }

        public ICommand OpenWorkerProfileCommand 
        {
           get { return new RelayCommand<WorkerRepository>(async workerRepository => await OpenWorkerProfileMethod(workerRepository)); }
        }

        #endregion


        #region Methods

        private async Task LoadData() 
        {
            Preferences.Set("ClientID", clientRepository.ClientID);
            var getAllWorkerRepository = await App.Database.GetAllWorkerRepositoryAsync(ClientRepository.ClientID) ?? new List<WorkerRepository>();
            WorkerRepositories = new ObservableCollection<WorkerRepository>(getAllWorkerRepository);
        }

        private async Task UpdateMethod() {
            IsEnabled = false;

            #region Label Error

            if (string.IsNullOrEmpty(ClientRepository.PhoneNumber)) {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, "Phone number invalid", Languages.Accept);
                IsEnabled = true;
                return; 
            }

            if (string.IsNullOrEmpty(ClientRepository.FirstName)) {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.FirstnameError, Languages.Accept);
                IsEnabled = true;
                return; 
            }

            if (string.IsNullOrEmpty(ClientRepository.LastName)) {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LastnameError, Languages.Accept);
                IsEnabled = true;
                return; 
            }

            #endregion

            IsLoading = true;
            
            try {
                var isCompleted = await App.FirebaseAuthService.UpdateProfileAsync($"{ClientRepository.FirstName} {ClientRepository.LastName}");
                ClientRepository.ModificationDate = DateTime.Now.ToUniversalTime();
                if (isCompleted) { 
                    await App.FirebaseRTDBService.UpdateClient(new UserInfoModel(ClientRepository.FirstName, ClientRepository.LastName, ClientRepository.PhoneNumber, ClientRepository.ModificationDate), ClientRepository.CountryCode, ClientRepository.ClientID);
                    MessagingCenter.Send(ClientRepository, "UpdateProfile");
                    await App.Database.SaveClientRepositoryAsync(ClientRepository);
                }
                else
                {
                    return ;
                }
            } 
            catch (Exception ex) {
                Console.WriteLine($"Something is wrong: {ex.Message}");
            }
            finally
            {
                IsEnabled = true;
                IsLoading = false;
                await Application.Current.MainPage.Navigation.PopAsync();
            }  
        }

        private async Task ChangePasswordMethod()
        {
            IsEnabled = false;
            if (string.IsNullOrEmpty(NewPassword))
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Error, Languages.EmailError, Languages.Accept, null));
                IsEnabled = true;
                return;
            }
            IsLoading = true;

            try
            {
                bool isCompleted = await App.FirebaseAuthService.ChangeUserPasswordAsync(NewPassword.Trim());
                if (isCompleted)
                {
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Accept, Languages.DataError, Languages.Ok, null));
            }
            finally
            {
                IsLoading = false;
                IsEnabled = true;
            }
        }

        private async Task GetPhoneCodeMethod() 
        {
            IsEnabled = false;
            CountryModelPhone = await PopupHelper.PhoneCodePopup();
            IsEnabled = true;
        }

        private async Task OpenWorkerProfileMethod(WorkerRepository workerRepository) 
        {
            var getWorkerModel = new WorkerInfoModel();
            if (DateTime.Now.Subtract(workerRepository.ModificationDate).TotalDays > 60) 
            {
                getWorkerModel = await App.FirebaseRTDBService.GetWorker($"{workerRepository.CountryCode}/{workerRepository.WorkerID}");
            }
            else 
            {
                getWorkerModel = new WorkerInfoModel 
                {
                    Rating = new RatingModel(workerRepository.RatingsValue, 5),
                    StaticInfo = new StaticWorkerInfo(workerRepository.WorkerID , workerRepository.SubCategory, workerRepository.Email, workerRepository.CountryCode, DateTime.Now),
                    Location = new LocationModel(workerRepository.Latitude, workerRepository.Longitude),
                    SimpleInfo = new UserInfoModel (workerRepository.FirstName , workerRepository.LastName, workerRepository.PhoneNumber, workerRepository.ModificationDate),
                };
            }

            await Application.Current.MainPage.Navigation.PushAsync(new ProfileWorkerPage(getWorkerModel, false));
        }
        
        private void CopyProfileDataMethod(string ProfileData) 
        {
           Clipboard.SetTextAsync(ProfileData ?? string.Empty);
           CrossToastPopUp.Current.ShowToastSuccess("Copied");
        }

        #endregion
   
    }

     
}
