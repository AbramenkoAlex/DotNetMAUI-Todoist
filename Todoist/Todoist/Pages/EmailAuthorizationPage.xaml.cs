using Todoist.ViewModels;

namespace Todoist.Pages;

public partial class EmailAuthorizationPage : ContentPage
{
    private readonly AuthorizationFormViewModel _formViewModel;

    public EmailAuthorizationPage()
	{
        _formViewModel = new AuthorizationFormViewModel()
        {
            TapFormCommand = new Command(OnFormViewTap),
            SubmitFormCommand = new Command(OnFormViewSubmit),
            CloseFormCommand = new Command(OnFormViewClose)
        };

        // This piece of code and the next on the 25 line is needed due to a strange work of Button enabling with Multibinding:
        // on a page initializing the result of multibinding is ignoring
        _formViewModel.IsSubmitted = true;

        BindingContext = _formViewModel;
        InitializeComponent();

        _formViewModel.IsSubmitted = false;
    }

    private void OnFormViewTap()
    {
#if IOS
	    Platforms.iOS.Helpers.KeyboardHelper.HideKeyboard();
#elif ANDROID
        Platforms.Android.Helpers.KeyboardHelper.HideKeyboard();
#endif
    }

    private void OnFormViewSubmit()
    {
        _formViewModel.IsSubmitted = !_formViewModel.IsSubmitted;
    }

    private async void OnFormViewClose()
    {
        await Shell.Current.GoToAsync("..", true);
    }
}