using Android.Content;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Yepa.Renderers.EditorChat), typeof(Yepa.Droid.Renderers.EditorChatRenderer))]

namespace Yepa.Droid.Renderers {
    public class EditorChatRenderer : EditorRenderer {

        public EditorChatRenderer(Context context) : base(context) {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e) {
            base.OnElementChanged(e);

            var view = (Yepa.Renderers.EditorChat)Element;
            if (view == null) return;

            var textview = new FormsEditText(Context) { 
                InputType = Android.Text.InputTypes.TextFlagMultiLine,                
            };

            // overriding Xamarin Forms Label and replace with our native control
            SetNativeControl(textview);
        }

    }

}