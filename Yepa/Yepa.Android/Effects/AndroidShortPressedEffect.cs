

using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Yepa.Effects;

[assembly: ExportEffect(typeof(Yepa.Droid.Effects.AndroidShortPressedEffect), "ShortPressedEffect")]
namespace Yepa.Droid.Effects
{

    public class AndroidShortPressedEffect : PlatformEffect
    {
        private bool _attached;

        public static void Initialize() { }

        public AndroidShortPressedEffect()
        {
        }

        protected override void OnAttached()
        {
            //because an effect can be detached immediately after attached (happens in listview), only attach the handler one time.
            if (!_attached)
            {
                if (Control != null)
                {
                    Control.Clickable = true;
                    Control.Click += Control_Click;
                }
                else
                {
                    Container.Clickable = true;
                    Container.Click += Control_Click;
                }
                _attached = true;
            }
        }


        //  Invoke the command if there is one
        //  Android.Views.View.LongClickEventArgs e
        private void Control_Click(object sender, EventArgs e) {
            Console.WriteLine("Invoking short click command");
            var command = ShortPressedEffect.GetCommand(Element);
            command?.Execute(ShortPressedEffect.GetCommandParameter(Element));
        }
        protected override void OnDetached()
        {
            if (_attached)
            {
                if (Control != null)
                {
                    Control.Clickable = true;
                    Control.Click -= Control_Click;
                }
                else
                {
                    Container.Clickable = true;
                    Container.Click -= Control_Click;
                }
                _attached = false;
            }
        }
    }
}