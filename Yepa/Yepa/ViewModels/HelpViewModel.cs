using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Yepa.Helpers;
using Yepa.Models;
using Yepa.Services;
using Yepa.Views.Popup;

namespace Yepa.ViewModels{
    class HelpViewModel : BaseViewModel
    {

        #region Constructor

        public HelpViewModel() 
        {
            IsEnabled = true;
            ListSettings = LoadList();
        }

        #endregion


        readonly FirebaseRTDBService FirebaseRTDBService = new FirebaseRTDBService();
        public ObservableCollection<DataModel> ListSettings { get; set; }


        #region Attributes

        public bool navigation = true;
        public bool isenabled;

        #endregion


        #region Properties

        public bool IsEnabled 
        {
            get { return isenabled; }
            set { SetValue(ref isenabled, value); }
        }

        #endregion


        #region Commands

        public ICommand SelectedOptionCommand 
        {
            get { return new RelayCommand<DataModel>(async optionSelected => await SelectedOptionMethod(optionSelected)); }
        }

        #endregion


        #region Methods

        private async Task SelectedOptionMethod(DataModel dataModel) 
        {
            IsEnabled = false;
            switch (dataModel.Key) {
                case 1:
                    //await SelectTheme();
                    break;
                case 2:
                    var getProblem = new PromptPopup("Consulta tu problema", null, null, null, "Comenta tu problema", 100, Keyboard.Text, "", 100);
                    await PopupNavigation.Instance.PushAsync(getProblem);
                    await FirebaseRTDBService.ReportProblem(getProblem.PopupClosedTask.Result, $"{LocationHelper.Placemark.CountryCode}/{LocationHelper.Placemark.AdminArea}");
                    break;
                case 3:
                    var getCommentsRecommendations = new PromptPopup("Recomendaciones y Comentarios", null, null, null, "Comenta...", 100, Keyboard.Text, "", 100);
                    await PopupNavigation.Instance.PushAsync(getCommentsRecommendations);
                    await FirebaseRTDBService.CommentsRecommendations(getCommentsRecommendations.PopupClosedTask.Result, $"{LocationHelper.Placemark.CountryCode}/{LocationHelper.Placemark.AdminArea}");
                    break;
                case 4:
                    await PopupNavigation.Instance.PushAsync(new ChangeFontSizePopup());
                    break;
                case 5:
                    await PopupNavigation.Instance.PushAsync(new ChangeFontSizePopup());
                    break;
                default:
                    break;
            }
            IsEnabled = true;
        }

        public ObservableCollection<DataModel> LoadList()
        {
            var helpers = new ObservableCollection<DataModel>()
            {
                new DataModel() { Key = 1, Data = "Centro de Ayuda", Icon = FontFontello.Icon_Help },
                new DataModel() { Key = 2, Data = "Consulta tu problema", Icon = FontFontello.Icon_FontSize },
                new DataModel() { Key = 3, Data = "Recomendaciones y Comentarios", Icon = FontFontello.Icon_Chat },
                new DataModel() { Key = 4, Data = "Condiciones y Privacidad", Icon = FontFontello.Icon_FontSize },
                new DataModel() { Key = 5, Data = "Info. de la Aplicación", Icon = FontFontello.Icon_Info },
            };
            return helpers;
        }

        #endregion

    }
}

