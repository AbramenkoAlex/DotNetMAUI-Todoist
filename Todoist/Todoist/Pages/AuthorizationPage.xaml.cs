using CommunityToolkit.Maui.Views;
using Todoist.Constants;
using Todoist.Views;

namespace Todoist.Pages;

public partial class AuthorizationPage : ContentPage
{
    private readonly IDeviceDisplay _deviceDisplay;

    public AuthorizationPage(IDeviceDisplay deviceDisplay)
	{
        BindingContext = this;
        InitializeComponent();

        _deviceDisplay = deviceDisplay;

        TermsOfServiceLabel.Url = RawResourcesConstants.TermsOfServicePage;
        TermsOfServiceLabel.TapGestureCommand = new Command<string>(ShowWebViewPopup);

        PrivacyPolicyLabel.Url = UrlConstants.PrivacyPolicy;
        PrivacyPolicyLabel.TapGestureCommand = new Command<string>(ShowWebViewPopup);
    }

    private void ShowWebViewPopup(string url)
    {
        var popup = new WebViewPopup(url, _deviceDisplay);
        this.ShowPopup(popup);
    }
}