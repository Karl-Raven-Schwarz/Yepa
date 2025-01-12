using System;
using System.Threading.Tasks;
using Yepa.Helpers;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Yepa.Models;
using Xamarin.Forms;
using Yepa.Views.Home;
using System.Linq;
using Rg.Plugins.Popup.Services;
using Yepa.Views.Popup;

namespace Yepa.ViewModels 
{

    public class WorkViewModel : BaseViewModel 
    {

        #region Constructor

        public WorkViewModel() 
        {
            IsEnabled = true;
            _ = LoadData();
        }

        #endregion


        #region Attributes
        
        ObservableCollection<SubCategoryModel> subCategories = new ObservableCollection<SubCategoryModel>();
        bool isWorking;
        bool isEnabled;
        string message;
        string translatedMessage;
        private ObservableCollection<SubCategoryModel> searchResults = new ObservableCollection<SubCategoryModel>();

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

        public bool IsEnabled 
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        public ObservableCollection<SubCategoryModel> SearchResults
        {
            get { return searchResults; }
            set { SetValue(ref searchResults, value); }
        }

        #endregion


        #region Commands

        public ICommand GetLocation 
        {
            get { return new RelayCommand(async () => await LocationHelper.Localize()); }
        }

        public ICommand SelectSubcategoryCommand
        {
            get { return new RelayCommand<SubCategoryModel>(async subCategory => await SelectSubcategoryMethod(subCategory)); }
        }

        public ICommand SearchCommand
        {
            get { return new RelayCommand<string>(text => SearchMethod(text)); }
        }

        #endregion


        #region Methods

        public async Task LoadData() 
        {
            SearchResults = subCategories = SubCategoryModel.GetAllSubCategories();
            await LocationHelper.Localize();
            IsWorking = LocationHelper.IsWorking != true;
            Message = LocationHelper.Message;
            TranslatedMessage = LocationHelper.TranslatedMessage;
        }

        public async Task SelectSubcategoryMethod(SubCategoryModel subCategory) 
        {
            IsEnabled = false;
            try
            {
                if (!LocationHelper.IsWorking)
                {
                    await LocationHelper.Localize();
                    IsWorking = LocationHelper.IsWorking != true;
                    Message = LocationHelper.Message;
                    TranslatedMessage = LocationHelper.TranslatedMessage;
                    if (LocationHelper.IsWorking)
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new ListViewWorkers(subCategory.Id));
                    }
                }
                else
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new ListViewWorkers(subCategory.Id));
                }
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
            }
            finally
            {
                IsWorking = LocationHelper.IsWorking != true;
                Message = LocationHelper.Message;
                TranslatedMessage = LocationHelper.TranslatedMessage;
                IsEnabled = true;
            }
        }

        private void SearchMethod(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                SearchResults = subCategories;
            }
            else
            {
                SearchResults = new ObservableCollection<SubCategoryModel>(subCategories.Where(
                    i => i.Key.Contains(text) || i.Value.Contains(text)));
            }
        }

        #endregion

    }    
}
