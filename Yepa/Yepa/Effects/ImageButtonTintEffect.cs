using System.Linq;
using Xamarin.Forms;

namespace Yepa.Effects
{
    public static class ImageButtonTintEffectParameters
    {
        #region Public Fields

        public static readonly BindableProperty TintColorProperty = 
            BindableProperty.CreateAttached("TintColor", typeof(Color), typeof(ImageButtonTintEffectParameters), Color.Default, propertyChanged: OnTintColorPropertyChanged);

        #endregion  

        #region Public Methods

        public static Color GetTintColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(TintColorProperty);
        }

        public static void SetTintColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(TintColorProperty, value);
        }

        #endregion  

        #region Private Methods

        private static void OnTintColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ImageButton current)
            {
                if ((Color)newValue != Color.Default)
                {
                    if (!current.Effects.Any(e => e is ImageButtonTintEffect))
                        current.Effects.Add(Effect.Resolve(nameof(ImageButtonTintEffect)));
                }
                else
                {
                    if (current.Effects.Any(e => e is ImageButtonTintEffect))
                    {
                        var existingEffect = current.Effects.FirstOrDefault(e => e is ImageButtonTintEffect);
                        current.Effects.Remove(existingEffect);
                    }
                }
            }
        }

        #endregion  
    }

    public class ImageButtonTintEffect : RoutingEffect
    {
        #region Public Constructors

        public ImageButtonTintEffect() : base($"Yepa.{nameof(ImageButtonTintEffect)}")
        {
        }

        #endregion  
    }
}