


using Android.Content;
using Android.Text.Util;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

using static Yepa.Droid.Renderers.BetterLinkMovementMethod;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Yepa.Renderers.HyperLinkLabel), typeof(Yepa.Droid.Renderers.HyperLinkLabelRenderer))]

namespace Yepa.Droid.Renderers {
    public class HyperLinkLabelRenderer : ViewRenderer, IOnLinkClickListener, IOnLinkLongClickListener {


        public HyperLinkLabelRenderer(Context context) : base(context) {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e) {
            base.OnElementChanged(e);

            Android.Widget.ListView listView = new Android.Widget.ListView(Context);
            listView.StackFromBottom = true;
            listView.TranscriptMode = TranscriptMode.AlwaysScroll;

            var view = (Yepa.Renderers.HyperLinkLabel)Element;
            if (view == null) return;

            var textview = new TextView(Context) {
                Text = view.Text,
                TextSize = (float)view.FontSize,
            };
            textview.SetTextColor(view.TextColor.ToAndroid());
            textview.SetLinkTextColor(view.LinksColor.ToAndroid());

            Linkify(MatchOptions.All, new System.Collections.Generic.List<TextView> { textview }).SetOnLinkClickListener(this).SetOnLinkLongClickListener(this);

            textview.LongClickable = false;
            textview.Clickable = false;
            // overriding Xamarin Forms Label and replace with our native control
            SetNativeControl(textview);
        }

        public bool OnClick(TextView textView, string url) {
            var command = Yepa.Renderers.HyperLinkLabel.GetCommand(Element);
            //command?.Execute(Yepa.Effects.HyperLinkLabel.GetCommandParameter(Element));
            command?.Execute(url);
            return true;
        }

        public bool OnLongClick(TextView textView, string url) {
            var command = Yepa.Renderers.HyperLinkLabel.GetLongCommand(Element);
            command?.Execute((Yepa.Renderers.HyperLinkLabel.GetLongCommandParameter(Element)));
            return true;
        }
    }

}
