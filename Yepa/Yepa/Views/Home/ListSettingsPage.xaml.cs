using Yepa.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;

namespace Yepa.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListSettingsPage : ContentPage
    {
        public ListSettingsPage(ClientRepository clientRepository)
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel(clientRepository);
        }
    }
}