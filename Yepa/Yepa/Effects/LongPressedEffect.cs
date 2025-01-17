﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Yepa.Effects 
{
    public class LongPressedEffect : RoutingEffect 
    {
        public LongPressedEffect() : base("Yepa.LongPressedEffect") { }

        public static readonly BindableProperty CommandProperty = 
            BindableProperty.CreateAttached("LongCommand", typeof(ICommand), typeof(LongPressedEffect), (object)null);
        public static ICommand GetCommand(BindableObject view) 
        {
            return (ICommand)view.GetValue(CommandProperty);
        }

        public static void SetCommand(BindableObject view, ICommand value) 
        { 
            view.SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty CommandParameterProperty = 
            BindableProperty.CreateAttached("CommandParameter", typeof(object), typeof(LongPressedEffect), (object)null);
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
