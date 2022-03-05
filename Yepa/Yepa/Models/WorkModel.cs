using System.Collections.ObjectModel;
using Yepa.Helpers;

namespace Yepa.Models
{
    public class CategoryModel
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public ObservableCollection<SubCategoryModel> SubCategories { set; get; } = new ObservableCollection<SubCategoryModel>();

        public CategoryModel(string key, string value) 
        {
            Key = key;
            Value = value;
        }

        public static ObservableCollection<CategoryModel> GetCategories()
        {
            return new ObservableCollection<CategoryModel>
            {
                new CategoryModel("AssemblyInstallation", Languages.AssemblyInstallation),
                new CategoryModel("Confection", Languages.Confection),
                new CategoryModel("RepairMaintenance", Languages.RepairMaintenance),
                new CategoryModel("Transport", Languages.Transport),
            };
        }

        public CategoryModel() { }
    }

    public class SubCategoryModel
    {
        public string Value { get; set; }
        public string Key { get; set; }
        public string Id { get; set; }
        public string Icon { get; set; }

        public SubCategoryModel(string key, string value, string id, string icon) 
        {
            Key = key;
            Value = value;
            Id = id;
            Icon = icon; 
        }

        public SubCategoryModel(string key, string value, string id)
        {
            Key = key;
            Value = value;
            Id = id;
            Icon = string.Empty;
        }

        public static ObservableCollection<SubCategoryModel> GetSubCategories(string key)
        {
            _ = new ObservableCollection<SubCategoryModel>();
            ObservableCollection<SubCategoryModel> getSubCategories;
            switch (key)
            {
                case "AssemblyInstallation":
                    getSubCategories = new ObservableCollection<SubCategoryModel>()
                    {
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Aluminumjoinery , CategoriesWork.Aluminumjoinery),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Ceramicporcelain , CategoriesWork.Ceramicporcelain),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Computerassembly , CategoriesWork.Computerassembly),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.DrywallConstruction , CategoriesWork.DrywallConstruction),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domesticelectricalinstallation  , CategoriesWork.Domesticelectricalinstallation),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domestichydraulicinstallation , CategoriesWork.Domestichydraulicinstallation),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.MelamineFurniture , CategoriesWork.MelamineFurniture),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Metalconstructions , CategoriesWork.Metalconstructions),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Securitycameras  , CategoriesWork.Securitycameras),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Welding  , CategoriesWork.Welding),
                    };
                    break;
                case "Confection":
                    getSubCategories = new ObservableCollection<SubCategoryModel>
                    {
                        new SubCategoryModel(Languages.Confection ,Languages.Suits ,CategoriesWork.Suits),
                        new SubCategoryModel(Languages.Confection ,Languages.Makinguniforms ,CategoriesWork.Makinguniforms),
                    };
                    break;
                case "RepairMaintenance":
                    getSubCategories = new ObservableCollection<SubCategoryModel>
                    {
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Cellrepairmaintenance,CategoriesWork.Cellrepairmaintenance),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Computerrepairmaintenance,CategoriesWork.Computerrepairmaintenance),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Repairmaintenancehouseholdappliances,CategoriesWork.Repairmaintenancehouseholdappliances),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Printerrepairmaintenance,CategoriesWork.Printerrepairmaintenance),
                    };
                    break;
                case "Transport":
                    getSubCategories = new ObservableCollection<SubCategoryModel>
                    {
                        new SubCategoryModel(Languages.Transport,Languages.Freighttransport,CategoriesWork.Freighttransport),
                        new SubCategoryModel(Languages.Transport,Languages.Personaltransportation,CategoriesWork.Personaltransportation),
                    };
                    break;
                default:
                    getSubCategories = new ObservableCollection<SubCategoryModel>()
                    {
                        //  AssemblyInstallation
                        new SubCategoryModel(Languages.AssemblyInstallation , Languages.Aluminumjoinery , CategoriesWork.Aluminumjoinery),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Ceramicporcelain , CategoriesWork.Ceramicporcelain),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Computerassembly , CategoriesWork.Computerassembly),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.DrywallConstruction , CategoriesWork.DrywallConstruction),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domesticelectricalinstallation  , CategoriesWork.Domesticelectricalinstallation),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domestichydraulicinstallation , CategoriesWork.Domestichydraulicinstallation),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.MelamineFurniture , CategoriesWork.MelamineFurniture),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Metalconstructions , CategoriesWork.Metalconstructions),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Securitycameras  , CategoriesWork.Securitycameras),
                        new SubCategoryModel(Languages.AssemblyInstallation,Languages.Welding,CategoriesWork.Welding),
                        new SubCategoryModel(Languages.Confection ,Languages.Suits ,CategoriesWork.Suits ),
                        new SubCategoryModel(Languages.Confection ,Languages.Makinguniforms ,CategoriesWork.Makinguniforms ),
                        //  RepairMaintenance
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Cellrepairmaintenance,CategoriesWork.Cellrepairmaintenance),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Computerrepairmaintenance,CategoriesWork.Computerrepairmaintenance),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Repairmaintenancehouseholdappliances,CategoriesWork.Repairmaintenancehouseholdappliances),
                        new SubCategoryModel(Languages.RepairMaintenance,Languages.Printerrepairmaintenance,CategoriesWork.Printerrepairmaintenance),
                        //  Transport
                        new SubCategoryModel(Languages.Transport,Languages.Freighttransport,CategoriesWork.Freighttransport),
                        new SubCategoryModel(Languages.Transport,Languages.Personaltransportation,CategoriesWork.Personaltransportation),
                    };
                    break;
            };
            return getSubCategories;
        }

        public static ObservableCollection<SubCategoryModel> GetAllSubCategories()
        {
            // setting images
            string Icon_AssemblyInstallation = "Icon_AssemblyInstallation", Icon_Confection = "Icon_Confection", Icon_RepairMaintenance = "Icon_RepairMaintenance", Icon_Transport = "Icon_Transport";
            return  new ObservableCollection<SubCategoryModel>()
            {
                //  AssemblyInstallation
                new SubCategoryModel(Languages.AssemblyInstallation , Languages.Aluminumjoinery , CategoriesWork.Aluminumjoinery ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Ceramicporcelain , CategoriesWork.Ceramicporcelain ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Computerassembly , CategoriesWork.Computerassembly ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.DrywallConstruction , CategoriesWork.DrywallConstruction ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domesticelectricalinstallation  , CategoriesWork.Domesticelectricalinstallation ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Domestichydraulicinstallation , CategoriesWork.Domestichydraulicinstallation ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.MelamineFurniture , CategoriesWork.MelamineFurniture ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Metalconstructions , CategoriesWork.Metalconstructions ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Securitycameras  , CategoriesWork.Securitycameras ,Icon_AssemblyInstallation),
                new SubCategoryModel(Languages.AssemblyInstallation,Languages.Welding  , CategoriesWork.Welding ,Icon_AssemblyInstallation),
                //  Confection
                new SubCategoryModel(Languages.Confection ,Languages.Suits ,CategoriesWork.Suits ,Icon_Confection),
                new SubCategoryModel(Languages.Confection ,Languages.Makinguniforms ,CategoriesWork.Makinguniforms ,Icon_Confection),
                //  RepairMaintenance
                new SubCategoryModel(Languages.RepairMaintenance,Languages.Cellrepairmaintenance,CategoriesWork.Cellrepairmaintenance ,Icon_RepairMaintenance),
                new SubCategoryModel(Languages.RepairMaintenance,Languages.Computerrepairmaintenance,CategoriesWork.Computerrepairmaintenance ,Icon_RepairMaintenance),
                new SubCategoryModel(Languages.RepairMaintenance,Languages.Repairmaintenancehouseholdappliances,CategoriesWork.Repairmaintenancehouseholdappliances ,Icon_RepairMaintenance),
                new SubCategoryModel(Languages.RepairMaintenance,Languages.Printerrepairmaintenance,CategoriesWork.Printerrepairmaintenance ,Icon_RepairMaintenance),
                //  Transport
                new SubCategoryModel(Languages.Transport,Languages.Freighttransport,CategoriesWork.Freighttransport ,Icon_Transport),
                new SubCategoryModel(Languages.Transport,Languages.Personaltransportation,CategoriesWork.Personaltransportation ,Icon_Transport),
            };
        }
    }
}
