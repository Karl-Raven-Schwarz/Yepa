using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Helpers;
using Yepa.ViewModels;

namespace Yepa.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPageW : ContentPage 
    {
        public SignUpPageW() 
        {
            InitializeComponent();
            BindingContext = new SignUpViewModelWorker();
        }

        protected override bool OnBackButtonPressed()
        {
            return PopupHelper.OnBackButtonPressed();
        }
    }
}