using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yepa.Views.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PromptPopup : PopupPage
    {
        public PromptPopup(string title, string message, string accept = "OK", string cancel = "Cancel", string placeholder = null, int maxLength = -1, Keyboard keyboard = null, string initialValue = "", double Height = 0)
        {
            InitializeComponent();
            LoadData( title, message, accept, cancel, placeholder, maxLength, keyboard, initialValue, Height);
        }

        public int ColummSpan { get; set; }
        private readonly TaskCompletionSource<string> taskCompletionSource = new TaskCompletionSource<string>();
        public Task<string> PopupClosedTask { get { return taskCompletionSource.Task; } }

        public void LoadData(string title, string message, string accept = "OK", string cancel = "Cancel", string placeholder = null , int maxLength = -1, Keyboard keyboard = null, string initialValue = "", double Height = 0)
        {
            // Title
            if (title==null) { TitlePopup.IsVisible = false; }
            else { TitlePopup.Text = title; }

            // Message
            if (message == null) { Message.IsVisible = false; }
            else { Message.Text = message; }

            // Buttons
            if (placeholder != null) { EditorEntry.Placeholder = placeholder; }
            if (maxLength != -1) { EditorEntry.MaxLength = maxLength; }
            if (keyboard != null) { EditorEntry.Keyboard = keyboard; }
            if (initialValue != null) { EditorEntry.Text = initialValue; }
            else { EditorEntry.IsVisible = false; }
            if (Height != 0) { EditorEntry.HeightRequest = Height; }

            // Cancel
            if (!string.IsNullOrEmpty(cancel) && cancel.Trim()!="") { Cancel.Text = cancel; }
            else { Cancel.Text = "Cancel"; }

            // Accept
            if (!string.IsNullOrEmpty(accept) && accept.Trim() != "") { Accept.Text = accept; }
            else { Accept.Text = "OK"; }
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

        private void Accept_Clicked(object sender, EventArgs e)
        {
            Accept.IsEnabled = false;
            if (string.IsNullOrEmpty(EditorEntry.Text))
            {
                Accept.IsEnabled = true;
                return;
            }
            Accept.IsEnabled = true;
            taskCompletionSource.SetResult(EditorEntry.Text);
            PopupNavigation.Instance.PopAsync();
        }
    }
}