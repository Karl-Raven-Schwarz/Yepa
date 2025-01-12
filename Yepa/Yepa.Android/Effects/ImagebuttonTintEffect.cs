
using Android.Content.Res;
using Android.Graphics;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AWImageButton = AndroidX.AppCompat.Widget.AppCompatImageButton;

[assembly: ResolutionGroupName("Yepa")]
[assembly: ExportEffect(typeof(Yepa.Droid.Effects.ImageButtonTintEffect), nameof(Yepa.Effects.ImageButtonTintEffect))]

namespace Yepa.Droid.Effects
{
    public class ImageButtonTintEffect : PlatformEffect
    {
        #region Private Fields

        private static readonly int[][] _colorStates =
{
    new[] { global::Android.Resource.Attribute.StateEnabled },
    new[] { -global::Android.Resource.Attribute.StateEnabled }, //disabled state
    new[] { global::Android.Resource.Attribute.StatePressed } //pressed state
};

        #endregion Private Fields

        #region Protected Methods

        protected override void OnAttached()
        {
            UpdateTintColor();
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == Yepa.Effects.ImageButtonTintEffectParameters.TintColorProperty.PropertyName)
                UpdateTintColor();

            if (args.PropertyName == ImageButton.SourceProperty.PropertyName)
                UpdateTintColor();
        }

        #endregion Protected Methods

        #region Private Methods

        private void UpdateTintColor()
        {
            try
            {
                if (Control is AWImageButton imageButton)
                {
                    var androidColor = Yepa.Effects.ImageButtonTintEffectParameters.GetTintColor(this.Element).ToAndroid();

                    var disabledColor = androidColor;
                    disabledColor.A = 0x1C; //140

                    var pressedColor = androidColor;
                    pressedColor.A = 0x24; //180

                    imageButton.ImageTintList = new ColorStateList(_colorStates, new[] { androidColor.ToArgb(), disabledColor.ToArgb(), pressedColor.ToArgb() });
                    imageButton.ImageTintMode = PorterDuff.Mode.SrcIn;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    $"An error occurred when setting the {typeof(Yepa.Effects.ImageButtonTintEffect)} effect: {ex.Message}\n{ex.StackTrace}");
            }
        }

        #endregion Private Methods
    }
}