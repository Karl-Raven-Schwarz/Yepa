using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;

namespace Yepa.Views.Home 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewWorkers : ContentPage 
    {
        public ListViewWorkers(string subCategory) 
        {
            InitializeComponent();
            BindingContext = new ListWorkersViewModel(subCategory);
        }
    }

    class DistanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Models.WorkerPrincipalData workerData)
            {
                return Helpers.LocationHelper.DistanceToString(workerData.Distance);
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}