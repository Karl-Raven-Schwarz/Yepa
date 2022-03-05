namespace Yepa.Helpers
{
    using Interfaces;
    using Resources;
    using Xamarin.Forms;
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        #region Dictionary
        //    A
        public static string Accept => Resource.Accept;
        public static string Alert => Resource.Alert;
        //    C
        public static string CalificationError => Resource.CalificationError;
        public static string Categories => Resource.Categories;
        public static string Chats => Resource.Chats;
        public static string Confirmaccount => Resource.Confirmaccount;
        public static string Contatc => Resource.Contact;
        public static string Continue => Resource.Continue;
        public static string Createaccount => Resource.Createaccount;
        public static string Createnewaccount => Resource.Createnewaccount;
        //    D
        public static string DataError => Resource.DataError;
        //    E
        public static string Editprofile => Resource.Editprofile;
        public static string Email => Resource.Email;
        public static string EmailError => Resource.EmailError;
        public static string Emailnotactive => Resource.Emailnotactive;
        public static string Entercode => Resource.Entercode; 
        public static string Entercodesent => Resource.Entercodesent;
        public static string Enternewpassword => Resource.Enternewpassword;
        public static string Error => Resource.Error;
        //    F
        public static string Findaccount => Resource.Findaccount;
        public static string Firstname => Resource.Firstname;
        public static string FirstnameError => Resource.FirstnameError;
        public static string Forgotpassword => Resource.Forgotpassword;
        //    G
        public static string GetLocationError => Resource.GetLocationError;
        public static string GetLocation => Resource.GetLocation;
        public static string Givelocation => Resource.Givelocation;
        //    H
        public static string Haveacount => Resource.Haveacount;
        public static string Home => Resource.Home;
        //    I
        public static string Invalidlogin => Resource.Invalidlogin;
        //    L
        public static string Lastname => Resource.Lastname;
        public static string LastnameError => Resource.LastnameError;
        public static string LocationError => Resource.LocationError;
        public static string Login => Resource.Login;
        public static string Logout => Resource.Logout;
        //    N
        public static string Name => Resource.Name;
        public static string Newpassword => Resource.Newpassword;
        public static string No => Resource.No;
        //    O
        public static string Ok => Resource.Ok;
        //    P
        public static string Password => Resource.Password;
        public static string PasswordError => Resource.PasswordError;
        //    Q
        public static string Qualify => Resource.Qualify;
        //    R
        public static string Registernow => Resource.Registernow;
        //    S
        public static string Search => Resource.Search;
        public static string Settings => Resource.Settings;
        public static string Signincontinue => Resource.Signincontinue;
        public static string SingupVerification => Resource.SingupVerification;
        //    U
        public static string Username => Resource.Username;
        public static string UsernameError => Resource.UsernameError;
        //    W
        public static string Welcome => Resource.Welcome;
        public static string Welcomeback => Resource.Welcomeback;
        //    Y
        public static string Yes => Resource.Yes;
        public static string Yourapp => Resource.Yourapp;
        #endregion


        #region Categories
        //    AssemblyInstallation
        public static string AssemblyInstallation => Resource.AssemblyInstallation;
        #region AssemblyInstallation
        public static string AIAluminum => Resource.AIAluminum;
        public static string AICeramic => Resource.AICeramic;
        public static string AIComputers => Resource.AIComputers;
        public static string AIDrywall => Resource.AIDrywall;
        public static string AIElectrical => Resource.AIElectrical;
        public static string AIHydraulics => Resource.AIHydraulics;
        public static string AIMelamine => Resource.AIMelamine;
        public static string AIMetalconstructions => Resource.AIMetalconstructions;
        public static string AISecuritycameras => Resource.AISecuritycameras;
        public static string AIWelding => Resource.AIWelding;
        //----------------------------------
        public static string Aluminumjoinery => Resource.Aluminumjoinery;
        public static string Ceramicporcelain => Resource.Ceramicporcelain;
        public static string Computerassembly => Resource.Computerassembly;
        public static string Metalconstructions => Resource.Metalconstructions;
        public static string Securitycameras => Resource.Securitycameras;
        public static string DrywallConstruction => Resource.DrywallConstruction;
        public static string Domesticelectricalinstallation => Resource.Domesticelectricalinstallation;
        public static string Domestichydraulicinstallation => Resource.Domestichydraulicinstallation;
        public static string MelamineFurniture => Resource.MelamineFurniture;
        public static string Welding => Resource.Welding;
        #endregion
        //    Confection
        public static string Confection => Resource.Confection;
        #region Confection
        public static string CSuits => Resource.CSuits;
        public static string CUniforms => Resource.CUniforms;
        //----------------------------------
        public static string Suits => Resource.Suits;
        public static string Makinguniforms => Resource.Makinguniforms;
        #endregion
        //    RepairMaintenance
        public static string RepairMaintenance => Resource.RepairMaintenance;
        #region RepairMaintenance
        public static string RPCellphones => Resource.RPCellphones;
        public static string RPComputers => Resource.RPComputers;
        public static string RPHomeappliances => Resource.RPHomeappliances;
        public static string RPPrinters => Resource.RPPrinters;
        //----------------------------------
        public static string Cellrepairmaintenance => Resource.Cellrepairmaintenance;
        public static string Computerrepairmaintenance => Resource.Computerrepairmaintenance;
        public static string Repairmaintenancehouseholdappliances => Resource.Repairmaintenancehouseholdappliances;
        public static string Printerrepairmaintenance => Resource.Printerrepairmaintenance;
        #endregion
        //    Transport
        public static string Transport => Resource.Transport;
        #region Transport
        public static string TFreighttransportation => Resource.TFreighttransportation;
        public static string TPersonalTransportation => Resource.TPersonalTransportation;
        //----------------------------------
        public static string Freighttransport => Resource.Freighttransport;
        public static string Personaltransportation => Resource.Personaltransportation;
        #endregion
        #endregion

    }
}
