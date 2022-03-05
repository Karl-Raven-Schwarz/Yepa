using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Yepa.Behaviors;

namespace Yepa.Effects
{
    public class PhoneNumberMaskBehavior2 : BaseBehavior<Entry>
    {
        public static readonly BindableProperty MaskProperty =
            BindableProperty.Create("Mask", typeof(string), typeof(PhoneNumberMaskBehavior2), string.Empty, defaultBindingMode: BindingMode.TwoWay);
        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }
        protected override void OnAttachedTo(Entry entry)
        { 
            base.OnAttachedTo(entry);
            entry.TextChanged += OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.TextChanged -= OnEntryTextChanged;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == MaskProperty.PropertyName)
            {
                var bindable = AssociatedObject ?? new Entry();
                bindable.Placeholder = Models.CountryModel.GetPhoneFormat(Mask);
            }
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = sender as Entry;
            var text = entry.Text;
            text = text.Replace(".", "");

            // 2. Evaluating if the user is removing text
            if ((args.OldTextValue == null) || (args.OldTextValue.Length <= args.NewTextValue.Length))
            {
                // 3. Evaluating mask positions
                for (int i = Mask.Length; i >= text.Length; i--)
                {
                    if (Mask[(text.Length - 1)] != 'X')
                    {
                        text = text.Insert((text.Length - 1), Mask[(text.Length - 1)].ToString());
                    }
                }
            }
            else
            {
                if (text.Length > 1 && text[text.Length - 1] == ' ')
                {
                    text = text.Remove(text.Length - 1);
                }
            }
            text = text.Replace(".", "");

            entry.Text = text;
        }
    }

    public class PhoneNumberMaskBehavior
    {
        public static readonly BindableProperty MaskProperty =
            BindableProperty.CreateAttached("Mask", typeof(string), typeof(PhoneNumberMaskBehavior), default(string), BindingMode.OneWay, null, PropertyChanged);

        private static void PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Entry contentPage)
            {
                contentPage.TextChanged -= OnEntryTextChanged;
                contentPage.TextChanged += OnEntryTextChanged;
            }
        }

        private static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
           
            var entry = sender as Entry;
            var mask = GetMask(entry);
            var text = entry.Text;
            text = text.Replace(".", "");

            // 2. Evaluating if the user is removing text
            if ((args.OldTextValue == null) || (args.OldTextValue.Length <= args.NewTextValue.Length))
            {
                // 3. Evaluating mask positions
                for (int i = mask.Length; i >= text.Length; i--)
                {
                    if (mask[(text.Length - 1)] != 'X')
                    {
                        text = text.Insert((text.Length - 1), mask[(text.Length - 1)].ToString());
                    }
                }
            }
            else
            {
                if (text.Length > 1 && text[text.Length - 1] == ' ')
                {
                    text = text.Remove(text.Length - 1);
                }
            }
            text = text.Replace(".", "");

            entry.Text = text;
        }

        public static string GetMask(BindableObject bindableObject) => (string)bindableObject.GetValue(MaskProperty);

        public static void SetMask(BindableObject bindableObject, string value) => bindableObject.SetValue(MaskProperty, value);
    }

}

