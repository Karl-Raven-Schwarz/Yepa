using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;

namespace Yepa.Views.Popup 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneCodePopup : ContentPage
    {
        readonly ObservableCollection<CountryModel> Countries = new ObservableCollection<CountryModel>();

        public PhoneCodePopup(ObservableCollection<CountryModel> countries) 
        {
            InitializeComponent();
            Xamarin.Essentials.Preferences.Set("PopupActive", true);
            ListViewCountries.ItemsSource = Countries = countries;
        }

        private CountryModel taskResult = new CountryModel();
        private readonly TaskCompletionSource<CountryModel> taskCompletionSource = new TaskCompletionSource<CountryModel>();
        public Task<CountryModel> PopupClosedTask { get { return taskCompletionSource.Task; } }

        protected override void OnDisappearing()
        {
            taskCompletionSource.SetResult(taskResult);
            base.OnDisappearing();
        }

        private void ListViewCountries_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskResult = e.Item as CountryModel;
            Navigation.PopAsync(true);
        }

        void SearchContent_TextChanged(object sender, TextChangedEventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue)) 
            {
                ListViewCountries.ItemsSource = Countries;
            }
            else 
            {
                ListViewCountries.ItemsSource = Countries.Where(i =>
                    i.NativeName.ToLower().Contains(e.NewTextValue.ToLower())
                    || i.NativeName.Contains(e.NewTextValue)
                    || i.PhoneCode.Contains(e.NewTextValue)
                    || i.Name.ToLower().Contains(e.NewTextValue.ToLower())
                    );
            }
        }
    }
}