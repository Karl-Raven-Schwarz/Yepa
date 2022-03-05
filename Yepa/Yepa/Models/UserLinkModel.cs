namespace Yepa.Models
{
    public class UserLinkModel
    {
        public string Name { get; set; } = UserLinks.Unknown.ToString();
        public string Link { get; set; } = string.Empty;
    }

    public enum UserLinks
    {
        Unknown = 0,
        Facebook = 1,
        WhatsApp = 2,
        Telegram = 3,
        Instagram = 4,
        Signal = 5,
    }
}
