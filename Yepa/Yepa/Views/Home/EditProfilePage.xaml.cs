using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;
using Yepa.Models;

namespace Yepa.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfilePage : ContentPage
    {
        public EditProfilePage(UserInfoModel userInfoModel)
        {
            InitializeComponent();
            BindingContext = new UserViewModel(userInfoModel);
        }    
    }
}