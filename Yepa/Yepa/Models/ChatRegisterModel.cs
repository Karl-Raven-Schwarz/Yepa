namespace Yepa.Models
{
    public class ChatRegisterModel
    {
        public string UserID { get; set; } = string.Empty;
        public string KeyChat { get; set; } = string.Empty;
        public ChatRegisterModel() { }
        public ChatRegisterModel(string keyChat)
        {
            KeyChat = keyChat;
            UserID = null;
        }
    }
}
