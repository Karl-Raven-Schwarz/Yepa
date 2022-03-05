using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPasswordPage : ContentPage
    {
        public NewPasswordPage()
        {
            InitializeComponent();
            BindingContext = new UserViewModel();
        }
    }
}