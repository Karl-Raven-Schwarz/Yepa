using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Yepa.Helpers;

namespace Yepa.Views.Popup{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPopup : PopupPage{
       
        public AlertPopup(string title, string message, string accept, string cancel) {
            InitializeComponent();
            LoadData(title, message, accept, cancel);
        }

        ///<summary>
        ///<para>Cancel = null</para>
        ///</summary>
        public AlertPopup(string title, string message, string accept) {
            InitializeComponent();
            LoadData(title, message, null, accept);
        }

        ///<summary>
        ///<para>Accept = Ok and Cancel = Cancel</para>
        ///</summary>
        public AlertPopup(string title, string message ) 
        {
            InitializeComponent();
            LoadData(title, message, "Cancel", Languages.Ok);
        }

        private bool  IsAccepted { get; set; } = false;
        private readonly TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
        public Task<bool> PopupClosedTask { get { return taskCompletionSource.Task; } }
        
        public void LoadData(string title, string message, string accept, string cancel) {
            // Title
            if (title==null) {
                TitlePopup.IsVisible = false;
            }
            else{
                TitlePopup.Text = title;
            }

            // Message
            if (message == null) {
                Message.IsVisible = false;
            }
            else{
                Message.Text = message;
            }

            // Cancel
            if (cancel == null) {
                Cancel.IsVisible = false;
            }
            else{
                Cancel.Text = cancel;
            }

            // Accept
            if (accept == null) {
                Accept.IsVisible = false;
            }
            else{
                Accept.Text = accept;
            }
        }

        private void Accept_Clicked(object sender, EventArgs e) {
            Accept.IsEnabled = false;
            IsAccepted = true;
            PopupNavigation.Instance.PopAsync();
            Accept.IsEnabled = true;
        }
        
        private void Cancel_Clicked(object sender, EventArgs e) {
            Accept.IsEnabled = false;
            IsAccepted = false;
            PopupNavigation.Instance.PopAsync();
            Accept.IsEnabled = true;
        }

        public void BackButton(object sender, EventArgs e)
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

        protected override void OnDisappearing() {
            base.OnDisappearing();
            taskCompletionSource.SetResult(IsAccepted);
        }

    }
}