using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Yepa.Models
{
    /// <summary>
    /// <para><see cref="ObservableCollection{ChatRegisterModel}"/> : T is <see cref="ChatRegisterModel"/> <see cref="Chats"/></para>
    /// <para><see cref="ClientInfoModel"/> <see cref="Info"/></para>
    /// <para><see cref="UserConnectionModel"/> <see cref="Connection"/></para>
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// List Chats IDs in database.
        /// </summary>
        public ObservableCollection<ChatRegisterModel> Chats { get; set; } = new ObservableCollection<ChatRegisterModel>();
        public ObservableCollection<UserLinkModel> Links { get; set; } = new ObservableCollection<UserLinkModel>();
        public ClientInfoModel Info { get; set; } = new ClientInfoModel();
        public UserConnectionModel Connection { get; set; } = new UserConnectionModel();
    }

    /// <summary>
    /// <para><see cref="StaticClientInfo"/> <see cref="StaticInfo"/></para>
    /// <para><see cref="UserConnectionModel"/> <see cref="SimpleInfo"/></para>
    /// <para><see cref="LocationModel"/> <see cref="Location"/></para>
    /// </summary>
    public class ClientInfoModel
    {
        public StaticClientInfo StaticInfo { get; set; }
        public UserInfoModel SimpleInfo { get; set; }
        public LocationModel Location { get; set; }

        public ClientInfoModel() { }

        public ClientInfoModel(ClientRepository clientRepository, LocationModel locationModel)
        {
            StaticInfo = new StaticClientInfo(clientRepository.Email, clientRepository.CountryCode, clientRepository.CreationDate) ?? new StaticClientInfo();
            SimpleInfo = new UserInfoModel(clientRepository.FirstName, clientRepository.LastName, clientRepository.PhoneNumber, clientRepository.ModificationDate) ?? new UserInfoModel();
            Location = locationModel ?? new LocationModel();
        }
    }

    public class StaticClientInfo
    {
        public string Email { get; set; } = string.Empty;
        public string CountryCode { get; set; } = "US";
        public string RegionCode { get; set; } = "AL";
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public StaticClientInfo() { }

        public StaticClientInfo(string email, string countryCode, DateTime creationDate)
        {
            Email = email ?? Email;
            CountryCode = countryCode ?? CountryCode;
            CreationDate = creationDate == null ? CreationDate : creationDate;
        }
    }

    public class ClientRequestModel
    {
        public DateTime CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class ClientRepository
    {

        #region Properties

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ClientID { get; set; } = string.Empty;
        public string ChatsRegisters_Json { get; set; } = string.Empty;
        public OSAppTheme Theme { get; set; } = OSAppTheme.Light;
        public int FontSize { get; set; } = 16;
        public int CornerRadius { get; set; } = 10;
        public string ChatBackground { get; set; } = string.Empty;
        public string ImageProfile { get; set; } = string.Empty;
        //StaticClientInfo
        public string CountryCode { get; set; } = "US";
        public string RegionCode { get; set; } = "AL";
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Email { get; set; } = string.Empty;
        //UserInfoModel
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; } = string.Empty;

        #endregion

        public ClientRepository() { }

        /// <summary>
        /// <para name="clientInfoModel"></para>
        /// <para name="clientID"></para>
        /// <para name="oSAppTheme"></para>
        /// </summary>
        public ClientRepository(int id,string clientID ,OSAppTheme theme , ClientInfoModel clientInfoModel)
        {
            ID = id;
            ClientID = clientID ?? ClientID;
            Theme = theme;
            CountryCode = clientInfoModel.StaticInfo.CountryCode ?? CountryCode;
            RegionCode = clientInfoModel.StaticInfo.RegionCode ?? RegionCode;
            Email = clientInfoModel.StaticInfo.Email ?? Email;
            CreationDate = clientInfoModel.StaticInfo.CreationDate == null ? CreationDate : clientInfoModel.StaticInfo.CreationDate;
            FirstName = clientInfoModel.SimpleInfo.FirstName ?? FirstName;
            LastName = clientInfoModel.SimpleInfo.LastName ?? LastName;
            PhoneNumber = clientInfoModel.SimpleInfo.PhoneNumber ?? PhoneNumber;
            ModificationDate = clientInfoModel.SimpleInfo.ModificationDate == null ? ModificationDate : clientInfoModel.SimpleInfo.ModificationDate;
        }

    }
}
