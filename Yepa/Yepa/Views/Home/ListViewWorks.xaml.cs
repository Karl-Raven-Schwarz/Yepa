using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.Home 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewWorks : ContentPage
    {
        public ListViewWorks()
        {
            InitializeComponent();
            BindingContext = new WorkViewModel();
        }
    }
}