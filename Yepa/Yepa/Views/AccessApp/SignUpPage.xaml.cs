

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.AccessApp{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage{
        public SignUpPage() {
            InitializeComponent();
            BindingContext = new SignUpViewModel();
        }
        private async void NavToLogin_Clicked(object sender, EventArgs e){
            await Navigation.PopAsync();
        }
    }
}