namespace Yepa.Models
{
    public class SettingsModel
    {
        public int Key { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;

        public SettingsModel() { }

        public SettingsModel(int key ,string title ,string icon)
        {
            Key = key;
            Title = title ?? Title;
            Icon = icon ?? Icon;
        }
    }
}
