using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Yepa.Effects;

namespace Yepa.Behaviors 
{
    [Preserve(AllMembers = true)]
    public class MessageBehavior : BaseBehavior<Label> 
    {

        private const string LinksPatern = @"\b(?:https?://|www\.)\S+\.\S+\b";
        private const string PhoneNumberPatern = @"((\+[/]*)(\d[/]*){10,11}\b)|(\b\d{9}\b)";
        private const string EmailPattern = @"\b\S+\@\S+\.\S+\b";

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(MessageBehavior), null, defaultBindingMode: BindingMode.TwoWay);

        public ICommand Command 
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public Color HashtagColor { get; set; } = Color.Blue;

        protected override void OnAttachedTo(Label bindable) 
        {
            base.OnAttachedTo(bindable);
            AssociatedObject.PropertyChanged += AssociatedObject_PropertyChanged;
        }

        private void AssociatedObject_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) 
        {
            if (e.PropertyName == Label.FormattedTextProperty.PropertyName) 
            {
                var textValue = $"{AssociatedObject.FormattedText}";
                if (string.IsNullOrEmpty(textValue)) 
                {
                    return;
                }
                   
                AssociatedObject.FormattedText.Spans.Clear();
                var formatted = AssociatedObject.FormattedText;
                MatchCollection collection = Regex.Matches(textValue, LinksPatern, RegexOptions.Singleline);

                var lastIndex = 0;

                foreach (Match item in collection) 
                {
                    var foundText = item.Value;
                    if (item.Index > 0) {
                        var text = textValue.Substring(lastIndex, item.Index - lastIndex - 1);
                        formatted.Spans.Add(CreateSpan($"{text} "));
                    }
                    
                    lastIndex = item.Index + item.Length;

                    var span = CreateSpan($"{item.Value}", true);

                    formatted.Spans.Add(span);
                    if (Command != null) 
                    {

                        span.Effects.Add(Effect.Resolve($"Yepa.{nameof(LongPressedEffect)}"));
                        LongPressedEffect.SetCommand(span, Command);
                        LongPressedEffect.SetCommandParameter(span, "322 456 perro");
                        /*Effects.LongPressedEffect.SetCommand(span, Command);
                        Effects.LongPressedEffect.SetCommandParameter(span, span.Text);*/

                        /*
                        span.GestureRecognizers.Add(new TapGestureRecognizer() {
                            Command = Command,
                            CommandParameter = span.Text,
                        });
                        */
                    }
                }
                var remainingText = textValue.Substring(lastIndex);
                formatted.Spans.Add(CreateSpan(remainingText));
            }

        }


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == CommandProperty.PropertyName && Command != null) {
                var bindable = AssociatedObject ?? new Label();
                if (bindable.FormattedText != null && bindable.FormattedText.Spans.Any()) {
                    var hashTagSpans = bindable.FormattedText.Spans.Where(p => Regex.Match(p.Text, LinksPatern).Success);
                    foreach (var span in hashTagSpans) {
                        var tapRecognizer = span.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;
                        if (tapRecognizer != null) {
                            tapRecognizer.Command = Command;
                        }
                        else 
                        {
                            span.GestureRecognizers.Add(new TapGestureRecognizer() 
                            {
                                Command = Command,
                                CommandParameter = span.Text
                            });
                        }
                    }
                }
            }
        }

        protected override void OnDetachingFrom(Label bindable) 
        {
            base.OnDetachingFrom(bindable);
            AssociatedObject.PropertyChanged -= AssociatedObject_PropertyChanged;
            if (bindable.FormattedText != null && bindable.FormattedText.Spans.Any()) 
            {
                var hashTagSpans = bindable.FormattedText.Spans.Where(p => Regex.Match(p.Text, LinksPatern).Success);
                foreach (var span in hashTagSpans) 
                {
                    var tapRecognizer = span.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;
                    if (tapRecognizer != null) 
                    {
                        span.GestureRecognizers.Remove(tapRecognizer);
                    }
                }
            }
        }

        Span CreateSpan(string text, bool isHashTag = false) {
            var span = new Span() {
                Text = text,
            };

            if (isHashTag) 
            {
                span.TextColor = HashtagColor;
                /*Effects.ShortPressedEffect.SetCommand(span,Command);
                Effects.ShortPressedEffect.SetCommandParameter(span,span.Text);*/
                
            }
            return span;
        }
    }
}
