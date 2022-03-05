using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Yepa.Behaviors
{
    public class OnDisappearingBehavior
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(OnDisappearingBehavior), default(ICommand), BindingMode.OneWay, null, PropertyChanged);

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.CreateAttached("CommandParameter", typeof(object), typeof(OnDisappearingBehavior), default, BindingMode.OneWay, null);

        private static void PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ContentPage contentPage)
            {
                contentPage.Disappearing -= ContentPage_Disappearing;
                contentPage.Disappearing += ContentPage_Disappearing;
            }
        }

        private static void ContentPage_Disappearing(object sender, EventArgs e)
        {
            if (sender is ContentPage contentPage && contentPage.IsEnabled)
            {
                var command = GetCommand(contentPage);
                var CommandParameter = GetCommandParameter(contentPage);

                if (command != null && command.CanExecute(CommandParameter))
                {
                    command.Execute(CommandParameter);
                }
            }
        }

        public static ICommand GetCommand(BindableObject bindableObject) => (ICommand)bindableObject.GetValue(CommandProperty);

        public static void SetCommand(BindableObject bindableObject, object value) => bindableObject.SetValue(CommandProperty, value);

        public static object GetCommandParameter(BindableObject bindableObject) => bindableObject.GetValue(CommandParameterProperty);

        public static void SetCommandParameter(BindableObject bindableObject, object value) => bindableObject.SetValue(CommandParameterProperty, value);
    }
}
