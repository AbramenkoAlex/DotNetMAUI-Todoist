using Todoist.Constants;
using Todoist.Pages;

namespace Todoist;

public partial class AppShell : Shell
{
	public AppShell()
	{
        Routing.RegisterRoute(ShellNavigationConstants.EmailAuthorizationPage, typeof(EmailAuthorizationPage));

        InitializeComponent();
    }
}
