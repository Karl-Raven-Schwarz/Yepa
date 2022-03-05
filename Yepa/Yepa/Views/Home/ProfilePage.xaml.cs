using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.Home 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage 
    {
        public ProfilePage(Models.ClientRepository clientRepository) 
        {
            InitializeComponent();
            BindingContext = new UserViewModel(clientRepository);
        }

        private void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                ImageGrid.HeightRequest = height*.65;
            }
            else
            {
                ImageGrid.HeightRequest = width*.55;
            }
        }
    }
}