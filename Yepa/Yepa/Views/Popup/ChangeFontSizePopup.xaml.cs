using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;
using Yepa.Views.Home;

namespace Yepa.Views.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeFontSizePopup : PopupPage
    {
        public int FontSize;
        public ChangeFontSizePopup()
        {
            InitializeComponent();

            WokerMessage.FontSize = ClientMessage.FontSize = slider.Value = FontSize = Preferences.Get("FontSize", 16);
            WorkerDate.FontSize = ClientDate.FontSize = .75 * FontSize;

            Value.Text = FontSize.ToString();

            WokerMessage.Text = "Hello Mrs. Martha";
            ClientMessage.Text = "Hello Mr. Lucas, I need your help for today";

           
            WorkerDate.Text = DateTime.Now.ToLocalTime().ToString("0:h:mm tt");
            ClientDate.Text = DateTime.Now.AddMinutes(0.5).ToLocalTime().ToString("0:h:mm tt");

            Preferences.Set("PopupActive", true);
        }
        
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider.Value = Convert.ToInt32(slider.Value);
            Value.Text = slider.Value.ToString();

            if (FontSize == Convert.ToInt32(slider.Value))  
            { 
                return; 
            }
            WokerMessage.FontSize = ClientMessage.FontSize = FontSize = Convert.ToInt32(slider.Value);
            WorkerDate.FontSize = ClientDate.FontSize = .75 * FontSize;
        }

        public void BackButton(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            if (Preferences.Get("PopupActive", false)) 
            {
                return false;
            }
            else
            {
                PopupNavigation.Instance.PopAsync();
                return true;
            }
            
        }

        protected override bool OnBackgroundClicked()
        {
            return base.OnBackgroundClicked();
        }

        protected override void OnDisappearing()
        {
            Preferences.Set("PopupActive", false);
            Preferences.Set("FontSize", FontSize);
            base.OnDisappearing();
        }
    }
}