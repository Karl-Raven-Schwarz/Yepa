using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Yepa.Effects;

[assembly: ExportEffect(typeof(Yepa.Droid.Effects.AndroidLongPressedEffect), "LongPressedEffect")]
namespace Yepa.Droid.Effects {

    public class AndroidLongPressedEffect : PlatformEffect {
        private bool _attached;
        public static void Initialize() { }

        public AndroidLongPressedEffect() { }

        protected override void OnAttached() {
            //because an effect can be detached immediately after attached (happens in listview), only attach the handler one time.
            if (!_attached) {
                if (Control != null) {
                    Control.LongClickable = true;
                    Control.LongClick += Control_LongClick;
                    /*  Control.Clickable = true;
                      Control.Click += Control_Click;*/
                }
                else {
                    Container.LongClickable = true;
                    Container.LongClick += Control_LongClick;
                    /*   Container.Clickable = true;
                       Container.Click += Control_Click;*/
                }
                _attached = true;
            }
        }

        // Invoke the command if there is one
        private void Control_LongClick(object sender, Android.Views.View.LongClickEventArgs e) {
            Console.WriteLine("Invoking long click command");
            var command = LongPressedEffect.GetCommand(Element);
            command?.Execute(LongPressedEffect.GetCommandParameter(Element));
        }

        private void Control_Click(object sender, EventArgs e) {
            Console.WriteLine("Invoking short click command");
            var command = LongPressedEffect.GetCommand(Element);
            command?.Execute(LongPressedEffect.GetCommandParameter(Element));
        }

        protected override void OnDetached() {
            if (_attached) {

                if (Control != null) {
                    Control.LongClickable = true;
                    Control.LongClick += Control_LongClick;
                    /* Control.Clickable = true;
                     Control.Click += Control_Click;*/
                }
                else {
                    Container.LongClickable = true;
                    Container.LongClick -= Control_LongClick;
                    /* Container.Clickable = true;
                     Container.Click -= Control_Click;*/
                }
                _attached = false;
            }
        }
    }
}