using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace Yepa.Views.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingPopup : PopupPage
    {
        public RatingPopup()
        {
            InitializeComponent();
        }

        public void BackButton(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            PopupNavigation.Instance.PopAsync();
            return base.OnBackButtonPressed();
        }

        protected override bool OnBackgroundClicked()
        {
            return base.OnBackgroundClicked();
        }
    }
}