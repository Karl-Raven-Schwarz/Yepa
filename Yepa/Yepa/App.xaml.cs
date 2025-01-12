using Xamarin.Forms;
using System.IO;
using Yepa.Database;
using System;
using Yepa.Models;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Plugin.Toast;
using Yepa.Services;
using Yepa.Views.AccessApp;
using System.Linq;

namespace Yepa 
{
    public partial class App : Application 
    {
        static ClientRepository MyClientRepository { get; set; }

        public static readonly string FirebaseApiKey = "AIzaSyCNaEq2ZH37Kjii1CHt9XMYpxkt2nsO7Gg";
        
        private static DatabaseQuerys database;
        public static DatabaseQuerys Database 
        {
            get 
            {
                if (database == null) 
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalDataBase.db3"));
                }
                return database;
            }
        }

        public static FirebaseAuthService FirebaseAuthService { get; private set; } = new FirebaseAuthService();

        public static FirebaseRTDBService FirebaseRTDBService { get; private set; } = new FirebaseRTDBService();

        public static OneSignalService OneSignalService { get; private set; } = new OneSignalService();

        public App () 
        {
            InitializeComponent();
            /*
            MainPage = new NavigationPage(new SignUpPageW());
            */
           
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                CrossToastPopUp.Current.ShowToastError("You're not online. Check the connection");
            }
            else
            {
                if (Preferences.Get("byToken", false)) 
                {         
                    MainPage = new NavigationPage(new LoadPage());
                }
                else 
                {
                    MainPage = new NavigationPage(new LogInPage());
                }
            }
        }

        public static ClientRepository GetClientRepository() { return MyClientRepository; }
        public static void SetClientRepository(ClientRepository clientRepository) { MyClientRepository = clientRepository; }

        protected override void OnStart() 
        {
        }

        protected override void OnSleep() 
        {
            FirebaseRTDBService.Destroy();
        }

        protected override void OnResume() 
        {
            FirebaseRTDBService.Initialize();
        }
    }
}

