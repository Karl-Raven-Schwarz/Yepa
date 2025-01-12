using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Yepa.Effects
{
    [Preserve(AllMembers = true)]
    public class TableViewSeparatorColor
    {
        public static readonly BindableProperty SeparatorColorChowProperty = 
            BindableProperty.CreateAttached("SeparatorColorChow", typeof(Color), typeof(TableViewSeparatorColor), Color.Default);

        public static Color GetSeparatorColorChow(BindableObject view)
        {
            return (Color)view.GetValue(SeparatorColorChowProperty);
        }

        public static void SetSeparatorColorChow(BindableObject view, Color value)
        {
            view.SetValue(SeparatorColorChowProperty, value);
        }
    }

    public class TableViewSeparatorColorEffect : RoutingEffect
    {
        public TableViewSeparatorColorEffect() : base("Yepa.TableViewSeparatorColorEffect") { }
    }
}
