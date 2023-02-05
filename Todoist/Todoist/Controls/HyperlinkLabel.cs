namespace Todoist.Controls
{
    public class HyperlinkLabel : Label
    {
        private static string DefaultUrl = "https://www.google.ru/";

        public static readonly BindableProperty TapGestureCommandProperty =
            BindableProperty.Create(nameof(TapGestureCommand), typeof(Command<string>), typeof(HyperlinkLabel), null);

        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkLabel), null);

        public Command<string> TapGestureCommand
        {
            get { return (Command<string>)GetValue(TapGestureCommandProperty); }
            set 
            {
                SetValue(TapGestureCommandProperty, value);

                GestureRecognizers.Clear();
                GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = TapGestureCommand,
                    CommandParameter = Url
                });
            }
        }

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set 
            { 
                SetValue(UrlProperty, value);

                foreach (var gestureRecognizer in GestureRecognizers)
                {
                    if (gestureRecognizer is TapGestureRecognizer tapGestureRecognizer)
                    {
                        tapGestureRecognizer.CommandParameter = Url;
                    }
                }
            }
        }

        public HyperlinkLabel()
        {
            TextDecorations = TextDecorations.Underline;
            GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command<string>(async (url) => await Launcher.OpenAsync(url)),
                CommandParameter = string.IsNullOrEmpty(Url) ? DefaultUrl : Url
            });
        }
    }
}
