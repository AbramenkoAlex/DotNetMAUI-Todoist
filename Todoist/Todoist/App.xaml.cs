using Todoist.Pages;

namespace Todoist;

public partial class App : Application
{
	public App(IDeviceDisplay deviceDisplay)
	{
		InitializeComponent();

		MainPage = new AuthorizationPage(deviceDisplay);
	}
}
