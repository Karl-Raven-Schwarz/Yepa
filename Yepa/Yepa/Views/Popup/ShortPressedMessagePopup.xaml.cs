
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Helpers;
using Yepa.Models;

namespace Yepa.Views.Popup{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShortPressedMessagePopup : PopupPage
    {
        public ShortPressedMessagePopup(ObservableCollection<GroupDataModel> options){
            InitializeComponent();
            CalculateHeight(options);
            ListOptions.ItemsSource = options;
        }

        public void CalculateHeight(ObservableCollection<GroupDataModel> options){
            int Count=0;
            for(int i=0;i<options.Count ; i++) 
            {
                Count+=options[i].Count;
            }
            if (Count>5) 
            { 
                ListOptions.HeightRequest = 500; 
            } 
            else { 
                ListOptions.HeightRequest = Count*100; 
            }
        }

        protected override bool OnBackButtonPressed()
        {
            PopupNavigation.Instance.PopAsync();
            return true;
        }

        protected override bool OnBackgroundClicked()
        {
            return base.OnBackgroundClicked();
        }
        private void ListOptions_ItemTapped(object sender, ItemTappedEventArgs e){
            var item = e.Item as DataModel;
            switch (item.Key){
                case 1:
                    if (!item.Data.Contains("http://")){
                        item.Data = "http://" + item.Data;
                    }
                    try{
                        Launcher.OpenAsync(new Uri(item.Data));
                    }
                    catch (UriFormatException ex){
                        Console.WriteLine($"Something is wrong: {ex.Message}");
                        App.Current.MainPage.DisplayAlert(Languages.Error, $"Something is wrong: {ex.Message}", Languages.Ok);
                    }
                    break;
                case 2:
                    try{
                        PhoneDialer.Open(item.Data);
                    }catch (Exception ex){
                        Console.WriteLine($"Something is wrong: {ex.Message}");
                        App.Current.MainPage.DisplayAlert(Languages.Error, "Ha ocurrido un error. Vielva a intentarlo", Languages.Ok);
                    }
                    break;
                case 3:
                    Email.ComposeAsync(item.Data,"","");
                    break;
                default:
                    break;
            }
            PopupNavigation.Instance.PopAsync();
        }
    
    }
}