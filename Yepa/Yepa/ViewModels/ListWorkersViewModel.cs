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
    class ListWorkersViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Constructor for open a saved worker profile in workers contacts
        /// </summary>
        public ListWorkersViewModel()
        {
            IsEnabled = IsLoading = false;
            IsEnabled = true;
        }

        /// <summary>
        /// Constructor to use in worker list
        /// </summary>
        /// <param name="subCategory"></param>
        public ListWorkersViewModel(string subCategory)
        {
            IsEnabled = IsLoading = false;
            SubCategory = subCategory;
            _ = LoadData();
            IsEnabled = true;
        }

        #endregion


        #region Attributes

        readonly string SubCategory;

        string message, translatedMessage;
        bool isWorking, isEnabled, isLoading;
        ObservableCollection<WorkerPrincipalData> workerModels = new ObservableCollection<WorkerPrincipalData>();
        ObservableCollection<WorkerPrincipalData> searchResults = new ObservableCollection<WorkerPrincipalData>();

        #endregion


        #region Properties

        public bool IsWorking
        {
            get { return isWorking; }
            set { SetValue(ref isWorking, value); }
        }

        public string Message
        {
            get { return message; }
            set { SetValue(ref message, value); }
        }

        public string TranslatedMessage
        {
            get { return translatedMessage; }
            set { SetValue(ref translatedMessage, value); }
        }

        public ObservableCollection<WorkerPrincipalData> SearchResults
        {
            get { return searchResults; }
            set { SetValue(ref searchResults, value); }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public bool IsLoading
        {
            get { return this.isLoading; }
            set { SetValue(ref this.isLoading, value); }
        }

        #endregion


        #region Commands

        public ICommand GetLocation
        {
            get { return new RelayCommand(async () => await ActualizeListMethod()); }
        }

        public ICommand RefreshCommand
        {
            get { return new RelayCommand(async () => await ActualizeListMethod()); }
        }

        public ICommand SearchCommand
        {
            get { return new RelayCommand<string>(text => SearchMethod(text)); }
        }

        public ICommand OpenProfileCommand 
        {
            get { return new RelayCommand<WorkerPrincipalData>(async principalData => await OpenProfileMethod(principalData)); }
        }

        #endregion


        #region Methods

        private async Task LoadData()
        {
            IsEnabled = false;
            if (LocationHelper.Placemark.Location.Latitude == 0 || LocationHelper.Placemark.Location.Longitude == 0)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, "Debes activar tu ubicacaión", Languages.Ok));
                IsEnabled = true;
                return;
            }
            try
            {
                await GetAllWorkers();
            }
            catch (Firebase.Database.FirebaseException FirebaseEx)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, FirebaseEx.Message));
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, ex.Message));
                try
                {
                    await GetAllWorkers();
                }
                catch (Exception ex2)
                {
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(Languages.Alert, "Compruebe su conexión a internet o vuelva a abrir la aplicación" + Environment.NewLine + ex2.Message));
                }
            }
            IsEnabled = true;
        }

        private async Task GetAllWorkers()
        {
            var getAllWorkers = new List<WorkerPrincipalData>();
            getAllWorkers = await App.FirebaseRTDBService.GetWorkers(SubCategory, 0);
            SearchResults = new ObservableCollection<WorkerPrincipalData>(getAllWorkers.OrderByDescending(item => item.RatingsValue).OrderBy(item => item.Distance).ToList());
            var isActive = true;
            for (int i = 0; isActive && i < 4; i++)
            {
                var getAllWorkers2 = await App.FirebaseRTDBService.GetWorkers(SubCategory, i);
                if (getAllWorkers.Count < 4)
                {
                    isActive = true;
                }
                else
                {
                    isActive = false;
                }
                workerModels.Union(getAllWorkers);
                SearchResults = workerModels;
            }
            SearchResults = new ObservableCollection<WorkerPrincipalData>(getAllWorkers.OrderByDescending(item => item.RatingsValue).OrderBy(item => item.Distance).ToList());
        }

        private async Task UpdateLocation()
        {
            await LocationHelper.Localize();
            IsWorking = LocationHelper.IsWorking != true;
            Message = LocationHelper.Message;
            TranslatedMessage = LocationHelper.TranslatedMessage;
        }

        private async Task OpenProfileMethod(WorkerPrincipalData workerPrincipalData)
        {
            IsEnabled = false;
            await Application.Current.MainPage.Navigation.PushAsync(new ProfileWorkerPage(workerPrincipalData, false));
            IsEnabled = true;
        }

        private async Task ActualizeListMethod()
        {
            IsEnabled = false;
            SearchResults = workerModels = new ObservableCollection<WorkerPrincipalData>();
            await UpdateLocation();
            await LoadData();
            IsEnabled = true;
        }

        private void SearchMethod(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                SearchResults = workerModels;
            }
            else
            {
                SearchResults = new ObservableCollection<WorkerPrincipalData>(workerModels.Where(
                    i => i.LastName.Contains(text) || i.FirstName.Contains(text) 
                    || i.LastName.ToLower().Contains(text.ToLower()) || i.FirstName.ToLower().Contains(text.ToLower())));
            }
        }

        #endregion
    }
}

