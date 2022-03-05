

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.AccessApp{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage{

        public LogInPage(){
            InitializeComponent();
            BindingContext = new LogInViewModel();
        }
    }
}