
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.AccessApp{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadPage : ContentPage{
        public LoadPage(){
            InitializeComponent();
            BindingContext = new LogInViewModel();
        }

    }
}