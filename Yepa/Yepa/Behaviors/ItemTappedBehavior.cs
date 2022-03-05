using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Yepa.Behaviors
{
    public class ItemTappedBehavior : BaseBehavior<ListView>
    {
        public static readonly BindableProperty CommandProperty = 
            BindableProperty.Create("Command", typeof(ICommand), typeof(ItemTappedBehavior), null, defaultBindingMode: BindingMode.TwoWay);

        public static readonly BindableProperty CommandParameterProperty = 
            BindableProperty.Create("CommandParameter", typeof(object), typeof(ItemTappedBehavior), null, defaultBindingMode: BindingMode.TwoWay);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemTapped += ListView_ItemTapped;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemTapped -= ListView_ItemTapped;
        }
        /*
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == CommandProperty.PropertyName)
            {
                var bindable = AssociatedObject ?? new ListView();
                bindable.ItemTapped = Models.CountryModel.GetPhoneFormat(Mask);
            }
        }
        */
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(CommandParameter == null) 
            { 
                Command?.CanExecute(e.Item);
            }
            else
            {
                Command?.Execute(CommandParameter);
            }
        }
    }

    public class TappedViewCellBehavior
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached( "Command", typeof(ICommand), typeof(TappedViewCellBehavior), default(ICommand), BindingMode.OneWay, null, PropertyChanged);

        public static readonly BindableProperty CommandParameterProperty = 
            BindableProperty.CreateAttached("CommandParameter", typeof(object), typeof(TappedViewCellBehavior),default,BindingMode.OneWay,null);

        private static void PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ViewCell viewCell)
            {
                viewCell.Tapped -= ViewCell_Tapped;
                viewCell.Tapped += ViewCell_Tapped;
            }
        }

        private static void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (sender is ViewCell cell && cell.IsEnabled)
            {
                var command = GetCommand(cell);
                var CommandParameter = GetCommandParameter(cell);

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
