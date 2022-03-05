using Android.Graphics.Drawables;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportEffect(typeof(Yepa.Droid.Effects.TableViewSeparatorColorEffect), "TableViewSeparatorColorEffect")]
namespace Yepa.Droid.Effects
{
    public class TableViewSeparatorColorEffect : PlatformEffect
    {
        Android.Graphics.Color color;

        protected override void OnAttached()
        {
            ConfigureControl();
        }

        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == Yepa.Effects.TableViewSeparatorColor.SeparatorColorChowProperty.PropertyName)
            {
                ConfigureControl();
            }
        }

        private void ConfigureControl()
        {
            try
            {
                var listView = Control as Android.Widget.ListView;
                color = /*Xamarin.Forms.Color.Green.ToAndroid();*/  Yepa.Effects.TableViewSeparatorColor.GetSeparatorColorChow(Element).ToAndroid();
                listView.Divider = new ColorDrawable(color);
                listView.DividerHeight = 1;
                listView.VerticalScrollBarEnabled = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred when setting the {typeof(Yepa.Effects.TableViewSeparatorColorEffect)} effect: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}