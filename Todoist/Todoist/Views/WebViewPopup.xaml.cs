using Android.Content.Res;
using CommunityToolkit.Maui.Views;

namespace Todoist.Views;

public partial class WebViewPopup : Popup
{
    private static double PopupWidthMultiplier = 0.9;
    private static double PopupHeightMultiplier = 0.9;

	public string UrlOrResourceName { get; set; }

	public WebViewPopup(string urlOrResourceName, IDeviceDisplay deviceDisplay)
	{
        UrlOrResourceName = urlOrResourceName;
        Size = new(
            PopupWidthMultiplier * (deviceDisplay.MainDisplayInfo.Width / deviceDisplay.MainDisplayInfo.Density),
            PopupHeightMultiplier * (deviceDisplay.MainDisplayInfo.Height / deviceDisplay.MainDisplayInfo.Density));

        BindingContext = this;
		InitializeComponent();
    }

    private void AgreementButton_Clicked(object sender, EventArgs e) => Close();
}