using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Yepa.Views.AccessApp{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage{
        public StartPage(){
            InitializeComponent();
        }

        private async void SignUp_Clicked(object sender, EventArgs e){
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void LogIn_Clicked(object sender, EventArgs e){
            await Navigation.PushAsync(new LogInPage());
        }
    }
}