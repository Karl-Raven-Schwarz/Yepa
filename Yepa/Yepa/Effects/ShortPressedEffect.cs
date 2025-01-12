using System.Windows.Input;
using Xamarin.Forms;

namespace Yepa.Effects
{
    public class ShortPressedEffect : RoutingEffect
    {
        public ShortPressedEffect() : base("Yepa.ShortPressedEffect") { }

        public static readonly BindableProperty CommandProperty = 
            BindableProperty.CreateAttached("ShortCommand", typeof(ICommand), typeof(ShortPressedEffect), (object)null);
        public static ICommand GetCommand(BindableObject view)
        {
            return (ICommand)view.GetValue(CommandProperty);
        }

        public static void SetCommand(BindableObject view, ICommand value) 
        { 
            view.SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty CommandParameterProperty = 
            BindableProperty.CreateAttached("CommandParameter", typeof(object), typeof(ShortPressedEffect), (object)null);
        public static object GetCommandParameter(BindableObject view)
        {
            return view.GetValue(CommandParameterProperty);
        }

        public static void SetCommandParameter(BindableObject view, object value)
        {
            view.SetValue(CommandParameterProperty, value);
        }
    }
}
