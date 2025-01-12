using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;

namespace Yepa.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewChats : ContentPage 
    {
        public ListViewChats(ClientRepository clientRepository, ObservableCollection<ChatRegisterModel> chatRegisterModels) 
        {
            InitializeComponent();
            BindingContext = new ViewModels.ChatViewModel(clientRepository, chatRegisterModels);
        }
    }
}