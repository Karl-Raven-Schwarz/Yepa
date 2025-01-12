using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;
using Yepa.ViewModels;

namespace Yepa.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreferencesPage : ContentPage
    {
        public PreferencesPage(ClientRepository clientRepository)
        {
            InitializeComponent();
            BindingContext = new PreferencesViewModel(clientRepository);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private void ContentPage_Disappearing(object sender, System.EventArgs e)
        {

        }
    }
}