namespace Yepa.Models {
    public class UserConnectionModel  {
        public UserConnectionModel () { }
        public UserConnectionModel (bool isConnected) {
            IsConnected = isConnected;
        }

        public bool IsConnected { get; set; } = false;
    }
}