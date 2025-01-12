using SQLite;
using System;
using System.Collections.ObjectModel;

namespace Yepa.Models 
{
    public class ChatModel 
    {
        /// <summary>
        /// Read and add new messages.
        /// </summary>
        public IDisposable MessagesListener { get; set; } = null;

        /// <summary>
        /// Chat ID in the database
        /// </summary>
        public string Key { get; set; } = string.Empty;
        
        /// <summary>
        /// Determines whether the green dot (indicating one or more new messages) is visible.
        /// </summary>
        public bool IsVisible { get; set; } = false;

        /// <summary>
        /// List of chat messages.
        /// </summary>
        //public ObservableCollection<MessageModel> Messages { get; set; }

        /// <summary>
        /// Information of chat
        /// </summary>
        public ChatInfoModel Info { get; set; }

        public ChatConnectionModel Connection { get; set; } = new ChatConnectionModel();
        public ChatModel () { }

        public ChatModel (ChatInfoModel chatInfoModel, string key) 
        {
            Info = chatInfoModel ?? new ChatInfoModel();
            Key = key ?? string.Empty;
        }

        public ChatModel(ChatInfoModel chatInfo)
        {
            Info = chatInfo ?? new ChatInfoModel();
            Connection = new ChatConnectionModel();
            Key = null;
        }

        public ChatModel(ChatInfoModel chatInfoModel, string key, IDisposable messagesListener)
        {
            Info = chatInfoModel ?? new ChatInfoModel();
            Key = key ?? string.Empty;
            MessagesListener = messagesListener;
        }
    }

    public class ChatInfoModel 
    {
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public string AES_Key { get; set; } = string.Empty;
        //------   USER
        public string ClientID { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        //------   WORKER
        public string WorkerID { get; set; } = string.Empty;
        public string WorkerName { get; set; } = string.Empty;

        public ChatInfoModel() { }

        public ChatInfoModel (ChatRepository chatRepository) 
        {
            AES_Key = chatRepository.AES_Key ?? AES_Key;
            ClientID = chatRepository.ClientID ?? ClientID;
            ClientName = chatRepository.ClientName ?? ClientName;
            CreationDate = chatRepository.CreationDate == null ? CreationDate : chatRepository.CreationDate;
            WorkerID = chatRepository.WorkerID ?? WorkerID;
            WorkerName = chatRepository.WorkerName ?? WorkerName;
        }

        public ChatInfoModel(ClientRepository clientRepository, WorkerInfoModel workerInfoModel, string aesKey, DateTime dateTime)
        {
            AES_Key = aesKey;
            ClientID = clientRepository.ClientID ?? ClientID;
            ClientName = $"{clientRepository.FirstName} {clientRepository.LastName}" ?? ClientName;
            CreationDate = dateTime;
            WorkerID = workerInfoModel.StaticInfo.ID ?? WorkerID;
            WorkerName = $"{workerInfoModel.SimpleInfo.FirstName} {workerInfoModel.SimpleInfo.LastName}" ?? WorkerName;
        }
    }

    /// <summary>
    /// Class to control the last modification of the chat, the last connection date of the client and the worker. 
    /// </summary>
    public class ChatConnectionModel 
    {
        /// <summary>
        /// Date of the last modification of the chat.
        /// Including the last sent messages
        /// </summary>
        public DateTime ModificationDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Last client connection date
        /// </summary>
        public DateTime LastConnectionClient { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Last worker connection date
        /// </summary>
        public DateTime LastConnectionWorker { get; set; } = DateTime.UtcNow;

        public ChatConnectionModel () { }

        public ChatConnectionModel(DateTime modificationDate, DateTime lastConnectionClient, DateTime lastConnectionWorker)
        {
            ModificationDate = modificationDate == null ? ModificationDate : modificationDate;
            LastConnectionClient = lastConnectionClient == null ? LastConnectionClient : lastConnectionClient;
            LastConnectionWorker = lastConnectionWorker == null ? LastConnectionWorker : lastConnectionWorker;
        }
    }

    /// <summary>
    /// Class for SQLite
    /// </summary>
    public class ChatRepository 
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } = 0;
        public string Key { get; set; } = string.Empty;
        public string Messages_Json { get; set; } = string.Empty;
        //ChatInfoModel
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public string AES_Key { get; set; } = string.Empty;
        //USER
        public string ClientID { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        //WORKER
        public string WorkerID { get; set; } = string.Empty;
        public string WorkerName { get; set; } = string.Empty;

        //ChatConnectionModel

        /// <summary>
        /// Date of the last modification of the chat.
        /// Including the last sent messages
        /// </summary>
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Last client connection date
        /// </summary>
        public DateTime LastConnectionClient { get; set; }

        /// <summary>
        /// Last worker connection date
        /// </summary>
        public DateTime LastConnectionWorker { get; set; }

        public ChatRepository() { }
        public ChatRepository(string key, ChatInfoModel chatInfoModel) 
        {
            Key = key ?? Key;
            AES_Key = chatInfoModel.AES_Key ?? AES_Key;
            ClientID = chatInfoModel.ClientID ?? ClientID;
            ClientName = chatInfoModel.ClientName ?? ClientName;
            CreationDate = chatInfoModel.CreationDate == null ? CreationDate : chatInfoModel.CreationDate;
            WorkerID = chatInfoModel.WorkerID ?? WorkerID;
            WorkerName = chatInfoModel.WorkerName ?? WorkerName;
        }
    }

}
