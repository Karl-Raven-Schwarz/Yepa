using Yepa.Models;
using Yepa.ViewModels;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Yepa.Views.Home;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Yepa.Views 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContainerTabbedPage : Xamarin.Forms.TabbedPage 
    {

        /// <summary>
        /// 
        /// <para>0 = <see cref="WorkViewModel"/> WorksList</para>
        /// <para>1 = <see cref="UserViewModel"/> Profile</para>
        /// <para>2 = <see cref="ChatViewModel"/> ChatsList</para>
        /// <para>3 = <see cref="SettingsViewModel"/> Settings</para>
        /// </summary>
        public ContainerTabbedPage (ClientRepository clientRepository, ObservableCollection<ChatRegisterModel> chatRegisterModels) 
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Top);
            On<Android>().SetIsSmoothScrollEnabled(true);
            On<Android>().SetIsSwipePagingEnabled(false);
            App.SetClientRepository(clientRepository);
            Children.Add(new ListViewWorks());
            Children.Add(new ProfilePage(clientRepository));
            Children.Add(new ListViewChats(clientRepository, chatRegisterModels));//Problem
            Children.Add(new ListSettingsPage(clientRepository));
            Children.Add(new AccessApp.SignUpPageW());
        }
    }
}