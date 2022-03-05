using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.ViewModels;
using Yepa.Models;
using System;
using System.Globalization;

namespace Yepa.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileWorkerPage : ContentPage
    {
        public ProfileWorkerPage(WorkerPrincipalData workerPrincipalData, bool Pop)
        {
            InitializeComponent();  
            BindingContext = new WorkerViewModel(workerPrincipalData, Pop);
        }

        public ProfileWorkerPage(WorkerInfoModel workerInfoModel, bool Pop)
        {
            InitializeComponent();
            BindingContext = new WorkerViewModel(workerInfoModel, Pop);
        }
    }

    class RatingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double rating)
            {
                if (rating == 0.0)
                {
                    return "0.0";
                }
                else
                {
                    bool isInt = rating % 1 == 0;
                    if (isInt) 
                    {
                        return rating.ToString() + ".0"; 
                    }
                    else 
                    { 
                        return Math.Round(rating,1).ToString();
                    }
                }
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