using System.Windows.Input;
using Xamarin.Forms;

namespace Yepa.Renderers 
{
    public class HyperLinkLabel : Label
    {
        public HyperLinkLabel() { }

        public Color LinksColor { get; set; } = Color.FromHex("#52D4E0");

        public static readonly BindableProperty CommandProperty = 
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(HyperLinkLabel), (object)null);

        public static ICommand GetCommand(BindableObject view) 
        {
            return (ICommand)view.GetValue(CommandProperty);
        }

        public static void SetCommand(BindableObject view, ICommand value) 
        {
            view.SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty LongCommandProperty = 
            BindableProperty.CreateAttached("LongCommand", typeof(ICommand), typeof(HyperLinkLabel), (object)null);

        public static ICommand GetLongCommand(BindableObject view) 
        { 
            return (ICommand)view.GetValue(LongCommandProperty);
        }

        public static void SetLongCommand(BindableObject view, ICommand value) 
        {
            view.SetValue(LongCommandProperty, value);
        }


        public static readonly BindableProperty LongCommandParameterProperty = 
            BindableProperty.CreateAttached("LongCommandParameter", typeof(object), typeof(HyperLinkLabel), (object)null);
        public static object GetLongCommandParameter(BindableObject view) 
        {
            return view.GetValue(LongCommandParameterProperty);
        }

        public static void SetLongCommandParameter(BindableObject view, object value) 
        {
            view.SetValue(LongCommandParameterProperty, value);
        }
    }
}
