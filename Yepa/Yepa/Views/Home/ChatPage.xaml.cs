using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;
using Yepa.ViewModels;
using System;
using SQLite;
using System.Globalization;
using System.ComponentModel;
using System.Threading.Tasks;
using Yepa.Helpers;

namespace Yepa.Views.Home 
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    
    public partial class ChatPage : ContentPage 
    {
        public ChatPage(ChatInfoModel chatInfo,ChatRepository _chatRepository)
        {
            InitializeComponent();
            BindingContext = new MessageViewModels(chatInfo, _chatRepository);
        }

        public ChatPage()
        {
            InitializeComponent();
        }

        private TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
        public Task<bool> ClosedTask 
        { 
            get { return taskCompletionSource.Task; } 
        }

        protected override bool OnBackButtonPressed()
        {
            return PopupHelper.OnBackButtonPressed();
        }

        protected override void OnDisappearing() 
        {
            taskCompletionSource.SetResult(true);
            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            taskCompletionSource = new TaskCompletionSource<bool>();
            base.OnAppearing();
        }
    }

    public class MessageDataTemplateSelector : DataTemplateSelector 
    {
        public DataTemplate Template { get; set; }
        public DataTemplate WorkerTemplate { get; set; }
        public DataTemplate ClientTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) {
            var gettemplate = new DataTemplate();
            switch (((MessageModel)item).Colum) {
                case 0:
                    gettemplate = ClientTemplate;
                    break;
                case 1:
                    gettemplate = Template;
                    break;
                case 2:
                    gettemplate = WorkerTemplate;
                    break;
                default:
                    break;
            }
            return gettemplate;
        }
    }

    class UtcToLocalDateTimeConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
        {
            if (value is DateTime dt) 
            {
                return dt.ToLocalTime();
            }
            else 
            {
                var t = DateTime.Parse(value?.ToString()).ToLocalTime();
                return t;
            }
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
        {
            return value;
        }
    }
}