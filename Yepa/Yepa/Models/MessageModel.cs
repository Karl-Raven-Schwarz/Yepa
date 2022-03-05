using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Yepa.Models{

    public class MessageModel : IEqualityComparer<MessageModel> {
        public MessageModel() 
        {
            Message = string.Empty;
            Colum = 0;
            CreationDate = DateTime.Now.ToUniversalTime();
        }

        public MessageModel(string message, int colum, DateTime creationDate) 
        {
            Message = message;
            Colum = colum;
            CreationDate = creationDate;
        }
        public string Message { get; set; }
        public int Colum { get; set; }
        public DateTime CreationDate { get; set; }

        public bool Equals(MessageModel x, MessageModel y) {
            return x.CreationDate == y.CreationDate && x.CreationDate.Second == y.CreationDate.Second
                && x.Message == y.Message;
        }

        public int GetHashCode(MessageModel obj) {
            return obj.CreationDate.GetHashCode() ^ obj.CreationDate.Second.GetHashCode()
                 ^ obj.Message.GetHashCode();
        }
    }

    public class MessageModelPopup : MessageModel {
        public int FontSize { get; set; }
        public string BackgroundColor { get; set; }
        public string TextColor { get; set; }

    }

    public class MessageRepository : MessageModel {
        public MessageRepository () { }
        public MessageRepository(MessageModel messageModel, string key) {
            Message = messageModel.Message;
            Colum = messageModel.Colum;
            CreationDate = messageModel.CreationDate;
            Key = key;
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Key { get; set; }
    }

}
