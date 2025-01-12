using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;

namespace Yepa.Views.Popup 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPopup : PopupPage 
    {
        public CategoryPopup(ObservableCollection<CategoryModel> categories) 
        {
            InitializeComponent();
            ListViewCategories.ItemsSource = categories;
            ListViewSubCategories.IsVisible = false;
        }

        public CategoryPopup(ObservableCollection<SubCategoryModel> subCategories)
        {
            InitializeComponent();
            ListViewSubCategories.ItemsSource = subCategories;
            ListViewSubCategories.HeightRequest = subCategories.Count * 51;
            ListViewCategories.IsVisible = false;
        }

        private string taskResult = string.Empty;
        private readonly TaskCompletionSource<string> taskCompletionSource = new TaskCompletionSource<string>();
        public Task<string> PopupClosedTask { get { return taskCompletionSource.Task; } }

        public void BackButton(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        private void ListViewCategories_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskResult = (e.Item as CategoryModel).Key;
            PopupNavigation.Instance.PopAsync();
        }

        private void ListViewSubCategories_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskResult = (e.Item as SubCategoryModel).Id;
            PopupNavigation.Instance.PopAsync();
        }

        protected override void OnDisappearing()
        {
            taskCompletionSource.SetResult(taskResult);
            base.OnDisappearing();
        }
    }
}