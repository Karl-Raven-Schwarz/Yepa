using Plugin.Toast;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;
using Yepa.Views.Home;

namespace Yepa.Views.Popup{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageSelectedPopup : Rg.Plugins.Popup.Pages.PopupPage{
        public MessageModel messageModel;
        public MessageSelectedPopup(MessageModel _messageModel){
            InitializeComponent();
            messageModel = _messageModel;

        }

        public async void BackButton(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

        public async void CopyMessage(object sender, EventArgs e){
            await Clipboard.SetTextAsync(messageModel.Message);
            CrossToastPopUp.Current.ShowToastError("Copied Message");
        }

        public async void InfoButton(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
            await App.Current.MainPage.Navigation.PushAsync(new MessageInfoPage(messageModel));
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