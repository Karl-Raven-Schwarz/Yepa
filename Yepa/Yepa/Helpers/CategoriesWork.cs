
namespace Yepa.Helpers
{
    using Resources;
    using Xamarin.Forms;
    using Interfaces;
    public static class CategoriesWork
    {
        static CategoriesWork()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        #region Categories
       
        //    AssemblyInstallation
        public static string AssemblyInstallation => ResourceCategory.AssemblyInstallation;
        #region AssemblyInstallation
        public static string Aluminumjoinery => ResourceCategory.Aluminumjoinery;
        public static string Ceramicporcelain => ResourceCategory.Ceramicporcelain;
        public static string Computerassembly => ResourceCategory.Computerassembly;
        public static string Metalconstructions => ResourceCategory.Metalconstructions;
        public static string Securitycameras => ResourceCategory.Securitycameras;
        public static string DrywallConstruction => ResourceCategory.DrywallConstruction;
        public static string Domesticelectricalinstallation => ResourceCategory.Domesticelectricalinstallation;
        public static string Domestichydraulicinstallation => ResourceCategory.Domestichydraulicinstallation;
        public static string MelamineFurniture => ResourceCategory.MelamineFurniture;
        public static string Welding => ResourceCategory.Welding;
        #endregion

        //    Confection
        public static string Confection => ResourceCategory.Confection;
        #region Confection
        public static string CSuits => ResourceCategory.CSuits;
        public static string CUniforms => ResourceCategory.CUniforms;
        //----------------------------------
        public static string Suits => ResourceCategory.Suits;
        public static string Makinguniforms => ResourceCategory.Makinguniforms;
        #endregion
        
        //    RepairMaintenance
        public static string RepairMaintenance => ResourceCategory.RepairMaintenance;
        #region RepairMaintenance
        public static string RPCellphones => ResourceCategory.RPCellphones;
        public static string RPComputers => ResourceCategory.RPComputers;
        public static string RPHomeappliances => ResourceCategory.RPHomeappliances;
        public static string RPPrinters => ResourceCategory.RPPrinters;
        //----------------------------------
        public static string Cellrepairmaintenance => ResourceCategory.Cellrepairmaintenance;
        public static string Computerrepairmaintenance => ResourceCategory.Computerrepairmaintenance;
        public static string Repairmaintenancehouseholdappliances => ResourceCategory.Repairmaintenancehouseholdappliances;
        public static string Printerrepairmaintenance => ResourceCategory.Printerrepairmaintenance;
        #endregion
        
        //    Transport
        public static string Transport => ResourceCategory.Transport;
        #region Transport
        public static string TFreighttransportation => ResourceCategory.TFreighttransportation;
        public static string TPersonalTransportation => ResourceCategory.TPersonalTransportation;
        //----------------------------------
        public static string Freighttransport => ResourceCategory.Freighttransport;
        public static string Personaltransportation => ResourceCategory.Personaltransportation;
        #endregion
        #endregion

    }
}
