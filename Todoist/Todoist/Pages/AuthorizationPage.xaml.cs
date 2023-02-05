using CommunityToolkit.Maui.Views;
using System.Windows.Input;
using Todoist.Views;

namespace Todoist.Pages;

public partial class AuthorizationPage : ContentPage
{
    public ICommand HyperlinkLabelTapGestureCommand => new Command<string>(ShowWebViewPopup);

    public AuthorizationPage()
	{
        BindingContext = this;
        InitializeComponent();
    }

    private void ShowWebViewPopup(string url)
    {
        var popup = new WebViewPopup(url);
        this.ShowPopup(popup);
    }

    private async void OnContinueWithEmailClick(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("email", true);
    }
}