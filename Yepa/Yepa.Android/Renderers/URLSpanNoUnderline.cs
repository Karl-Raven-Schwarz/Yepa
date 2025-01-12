

using Android.Text;
using Android.Text.Style;
using Android.Views;


namespace Yepa.Droid.Renderers {

    public class URLSpanNoUnderline : URLSpan {
        public URLSpanNoUnderline(string url) : base(url) {
        }

        public override void OnClick(View view) {
        }

        public override void UpdateDrawState(TextPaint ds) {
            base.UpdateDrawState(ds);
            ds.UnderlineText = false;
        }
    }
}