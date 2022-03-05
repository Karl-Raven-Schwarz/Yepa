using Android.Widget;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportEffect(typeof(Yepa.Droid.Effects.AutoScrollToLast), "ScrollToLastEffect")]

namespace Yepa.Droid.Effects 
{
    public class AutoScrollToLast : PlatformEffect 
    {
        protected override void OnAttached() 
        {
            ConfigureControl();
        }

        protected override void OnDetached() { }

        private void ConfigureControl() 
        {
            ListView listView = (ListView)Control;
            listView.StackFromBottom = true;
            listView.TranscriptMode = TranscriptMode.AlwaysScroll;
        }
    }      
}
