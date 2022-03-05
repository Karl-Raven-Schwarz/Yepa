using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Yepa.Models;
using System.Threading.Tasks;
using Yepa.Views.Popup;
using System.Collections.ObjectModel;

namespace Yepa.Helpers
{
    public static class PopupHelper
    {
        private static ObservableCollection<CountryModel> countriesForPhone = new ObservableCollection<CountryModel>();
        private static ObservableCollection<CountryModel> countries = new ObservableCollection<CountryModel>();
        private static ObservableCollection<SubCategoryModel> subCategories = new ObservableCollection<SubCategoryModel>();
        private static string category = string.Empty;

        public static bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                PopupNavigation.Instance.PopAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static async Task<string> ActionSheetPopup(string title,string cancel ,params string[] buttons) 
        {
            var actionSheetPopup = new ActionSheetPopup(title, cancel, buttons);
            await PopupNavigation.Instance.PushAsync(actionSheetPopup);
            return await actionSheetPopup.PopupClosedTask;
        }

        public static async Task<CountryModel> PhoneCodePopup()
        {
            if (countriesForPhone.Count == 0) 
            {
                countriesForPhone = CountryModel.GetCountriesForPhoneCOde();
            }
            var phoneCodePopup = new PhoneCodePopup(countriesForPhone);
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(phoneCodePopup);
            return await phoneCodePopup.PopupClosedTask;
        }

        public static async Task<CountryModel> CountryPopup()
        {
            if (countries.Count == 0)
            {
                countries = CountryModel.GetCountries();
            }
            var phoneCodePopup = new CountryPopup(countries);
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(phoneCodePopup,true);
            return await phoneCodePopup.PopupClosedTask;
        }

        public static async Task<string> CategoryPopup()
        {
            var categoryPopup = new CategoryPopup(CategoryModel.GetCategories());
            await PopupNavigation.Instance.PushAsync(categoryPopup);
            return await categoryPopup.PopupClosedTask; ;
        }

        public static async Task<string> SubCategoryPopup(string key)
        {
            if (subCategories.Count == 0 || key != category)
            {
                category = key;
                subCategories = SubCategoryModel.GetSubCategories(key);
            }
            var subCategoryPopup = new CategoryPopup(subCategories);
            await PopupNavigation.Instance.PushAsync(subCategoryPopup);
            return await subCategoryPopup.PopupClosedTask;
        }
    }
}
