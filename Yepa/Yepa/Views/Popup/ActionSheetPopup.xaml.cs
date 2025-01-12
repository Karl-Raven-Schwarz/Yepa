using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yepa.Views.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionSheetPopup : PopupPage
    {
        public ActionSheetPopup(string title, string cancel ,params string[] buttons)
        { 
            InitializeComponent();
            // Title
            TitlePopup.Text = title ?? string.Empty;
            // Cancel
            Cancel.Text = cancel ?? "Cancel";
            // Buttons
            Buttons.ItemsSource = buttons;

            Preferences.Set("PopupActive", true);
        }

        private readonly TaskCompletionSource<string> taskCompletionSource = new TaskCompletionSource<string>();
        public Task<string> PopupClosedTask 
        { 
            get { return taskCompletionSource.Task; }  
        }

        private void Buttons_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskCompletionSource.SetResult(e.Item as string);
            PopupNavigation.Instance.PopAsync();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
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
    }
}