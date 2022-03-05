using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Yepa.Helpers;

namespace Yepa.Models 
{

    public class WorkerModel 
    {
        /// <summary>
        /// Chat information
        /// </summary>
        public WorkerInfoModel Info { get; set; }

        /// <summary>
        /// Class to control the connection dates (client and worker) and the last modification date.
        /// </summary>
        public UserConnectionModel Connection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Distance { get; set; } = "Unknown";
    }

    /// <summary>
    /// Información actualizable.
    /// </summary>
    public class WorkerInfoModel 
    {
        public StaticWorkerInfo StaticInfo { get; set; } = new StaticWorkerInfo();
        public UserInfoModel SimpleInfo { get; set; } = new UserInfoModel();
        public LocationModel Location { get; set; } = new LocationModel();
        public RatingModel Rating { get; set; } = new RatingModel();
        public WorkerInfoModel() { }
        public WorkerInfoModel(WorkerRepository workerRepository, WorkerPrincipalData workerPrincipalData) 
        {
            StaticInfo = new StaticWorkerInfo
            {
                CountryCode = workerRepository.CountryCode,
                Email = workerRepository.Email,
                Subcategory = workerRepository.SubCategory,
                ID = workerPrincipalData.ID,
            };
            SimpleInfo = new UserInfoModel
            {
                FirstName = workerPrincipalData.FirstName,
                LastName = workerPrincipalData.LastName,
                ModificationDate = workerRepository.ModificationDate,
                PhoneNumber = workerRepository.PhoneNumber,
            };
            Location = new LocationModel(workerPrincipalData.Latitude, workerPrincipalData.Longitude);
            Rating = new RatingModel(workerPrincipalData.RatingsValue,0);
        }
    }

    /// <summary>
    /// Information with little possibility of updating.
    /// </summary>
    public class StaticWorkerInfo 
    {
        /// <summary>
        /// ID in database.
        /// </summary>
        public string ID { get; set; } = string.Empty;

        /// <summary>
        /// Worker subcategory.
        /// </summary>
        public string Subcategory { get; set; } = CategoriesWork.Aluminumjoinery;

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; } = "US";

        /// <summary>
        /// Profile creation date.
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public StaticWorkerInfo () { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="subcategory"></param>
        /// <param name="email"></param>
        /// <param name="countryCode"></param>
        /// <param name="creationDate"></param>
        public StaticWorkerInfo (string iD, string subCategory, string email, string countryCode, DateTime creationDate) {
            ID = iD ?? ID;
            Subcategory = subCategory ?? Subcategory;
            Email = email ?? Email;
            CountryCode = countryCode ?? CountryCode;
            CreationDate = creationDate == null ? CreationDate : creationDate;
        }

        public StaticWorkerInfo(StaticWorkerInfo staticWorkerInfo) {
            ID = staticWorkerInfo.ID ?? ID;
            Subcategory = staticWorkerInfo.Subcategory ?? Subcategory;
            Email = staticWorkerInfo.Email ?? Email;
            CountryCode = staticWorkerInfo.CountryCode ?? CountryCode;
            CreationDate = staticWorkerInfo.CreationDate != null ? staticWorkerInfo.CreationDate : CreationDate;
        }

    }

    public class PrivateInfo
    {
        /// <summary>
        /// Profile creation date.
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; } = "US";
    }

    public class ClientIDModel {

        /// <summary>
        /// Client ID in database.
        /// </summary>
        public string ClientID { get; set; } = string.Empty;
    }

    public class RatingModel 
    {

        /// <summary>
        /// Total rating valuee
        /// </summary>
        public double RatingsValue { get; set; } = 0.0;

        /// <summary>
        /// Number of ratings
        /// </summary>
        public int NumberRatings { get; set; } = 0;

        public RatingModel() { }

        public RatingModel(double ratingsValue, int numberRatings) {
            RatingsValue = ratingsValue;
            NumberRatings = numberRatings;
        }
    }

    public class WorkerPrincipalData
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
        public double RatingsValue { get; set; } = 0.0;
        public string ID { get; set; } = string.Empty;
        public double Distance { get; set; } = 0.0;
        public string ProfileImage { get; set; } = string.Empty;

        public WorkerPrincipalData() { }

        public WorkerPrincipalData(WorkerInfoModel workerInfoModel)
        {
            FirstName = workerInfoModel.SimpleInfo.FirstName;
            LastName = workerInfoModel.SimpleInfo.LastName;
            Latitude = workerInfoModel.Location.Latitude;
            Longitude = workerInfoModel.Location.Longitude;
            RatingsValue = workerInfoModel.Rating.RatingsValue;
        }
    }

    public class WorkerRepository 
    {
        public WorkerRepository () { }

        public WorkerRepository(WorkerInfoModel workerInformationModel,string clientID) 
        {
            ClientID = clientID ?? ClientID;
            PhoneNumber = workerInformationModel.SimpleInfo.PhoneNumber;
            FirstName = workerInformationModel.SimpleInfo.FirstName;
            LastName = workerInformationModel.SimpleInfo.LastName;
            ModificationDate = workerInformationModel.SimpleInfo.ModificationDate;
            WorkerID = workerInformationModel.StaticInfo.ID;
            SubCategory = workerInformationModel.StaticInfo.Subcategory;
            CountryCode = workerInformationModel.StaticInfo.CountryCode;
            Email = workerInformationModel.StaticInfo.Email;
            Latitude = workerInformationModel.Location.Latitude;
            Longitude = workerInformationModel.Location.Longitude;
            RatingsValue = workerInformationModel.Rating.RatingsValue;
            Distance = workerInformationModel.Location == null || workerInformationModel.Location == new LocationModel() ? 
                       "Unknown" : LocationHelper.DistanceToString(Location.CalculateDistance(workerInformationModel.Location.Latitude, workerInformationModel.Location.Longitude, LocationHelper.GetLocation(), DistanceUnits.Kilometers));
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ClientID { get; set; }
        public bool HaveChat { get; set; } = false;
        //----Information
        public string CountryCode { get; set; } = "US";
        public string WorkerID { get; set; } = string.Empty;
        public string SubCategory { get; set; } = CategoriesWork.Aluminumjoinery;
        public string Email { get; set; } = string.Empty;
        //--ChageableInformation
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public string Distance { get; set; } = "Unknown";
        //Rating 
        public double RatingsValue { get; set; } = 0.0;
        //--Location
        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
    }

}