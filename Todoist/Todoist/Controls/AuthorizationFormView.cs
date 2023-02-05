using System.Windows.Input;

namespace Todoist.Controls
{
    public class AuthorizationFormView : ContentView
    {
        public static readonly BindableProperty EmailProperty =
            BindableProperty.Create(nameof(Email), typeof(string), typeof(AuthorizationFormView), string.Empty, BindingMode.TwoWay);

        public static readonly BindableProperty PasswordProperty =
            BindableProperty.Create(nameof(Password), typeof(string), typeof(AuthorizationFormView), string.Empty, BindingMode.TwoWay);

        public static readonly BindableProperty TapCommandProperty =
            BindableProperty.Create(nameof(TapCommand), typeof(ICommand), typeof(AuthorizationFormView), null);

        public static readonly BindableProperty SubmitCommandProperty =
            BindableProperty.Create(nameof(SubmitCommand), typeof(ICommand), typeof(AuthorizationFormView), null);

        public static readonly BindableProperty CloseCommandProperty =
            BindableProperty.Create(nameof(CloseCommand), typeof(ICommand), typeof(AuthorizationFormView), null);

        public static readonly BindableProperty IsSubmittedProperty =
            BindableProperty.Create(nameof(IsSubmitted), typeof(bool), typeof(AuthorizationFormView), false, BindingMode.TwoWay);

        public string Email
        {
            get => (string)GetValue(EmailProperty);
            set => SetValue(EmailProperty, value);
        }

        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set => SetValue(PasswordProperty, value);
        }

        public ICommand TapCommand
        {
            get => (ICommand)GetValue(TapCommandProperty);
            set => SetValue(TapCommandProperty, value);
        }

        public ICommand SubmitCommand
        {
            get => (ICommand)GetValue(SubmitCommandProperty);
            set => SetValue(SubmitCommandProperty, value);
        }

        public ICommand CloseCommand
        {
            get => (ICommand)GetValue(CloseCommandProperty);
            set => SetValue(CloseCommandProperty, value);
        }

        public bool IsSubmitted
        {
            get => (bool)GetValue(IsSubmittedProperty);
            set => SetValue(IsSubmittedProperty, value);
        }
    }
}
