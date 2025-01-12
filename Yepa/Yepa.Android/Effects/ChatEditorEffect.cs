

using Android.Views;
using Android.Widget;
using System;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportEffect(typeof(Yepa.Droid.Renderers.ChatEditorEffect), "ChatEditorEffect")]

namespace Yepa.Droid.Renderers {
    public class ChatEditorEffect : PlatformEffect {

        protected override void OnAttached() {
            ConfigureControl();
        }

        protected override void OnDetached() { }

        private void ConfigureControl() {
            EditText chatEntryView = (EditText)Control;
            chatEntryView.ImeOptions = Android.Views.InputMethods.ImeAction.Send;
        }

    }      
}
