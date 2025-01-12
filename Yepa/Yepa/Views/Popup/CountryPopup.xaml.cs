using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;

namespace Yepa.Views.Popup 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class CountryPopup : ContentPage
    {
        readonly ObservableCollection<CountryModel> countries = new ObservableCollection<CountryModel>();
        public CountryPopup(ObservableCollection<CountryModel>  _countries) 
        {
            InitializeComponent();
            ListViewCountries.ItemsSource = countries = _countries;
        }

        private CountryModel taskResult = new CountryModel();
        private readonly TaskCompletionSource<CountryModel> taskCompletionSource = new TaskCompletionSource<CountryModel>();
        public Task<CountryModel> PopupClosedTask { get { return taskCompletionSource.Task; } }

        private void ListViewCountries_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskResult = e.Item as CountryModel;
            Navigation.PopAsync(true);
        }

        void SearchContent_TextChanged(object sender, TextChangedEventArgs e) 
        { 
            if (string.IsNullOrWhiteSpace(e.NewTextValue)) 
            {
                ListViewCountries.ItemsSource = countries;
            }
            else 
            {
                ListViewCountries.ItemsSource = countries.Where(i =>
                    i.NativeName.ToLower().Contains(e.NewTextValue.ToLower())
                    || i.NativeName.Contains(e.NewTextValue)
                    || i.Code.ToLower().Contains(e.NewTextValue.ToLower())
                    || i.Name.ToLower().Contains(e.NewTextValue.ToLower())
                    );
            }
        }
        protected override void OnDisappearing()
        {
            taskCompletionSource.SetResult(taskResult);
            base.OnDisappearing();
        }
    }
}