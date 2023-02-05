namespace Todoist;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }


    public App()
	{
        Services = ConfigureServices();

		InitializeComponent();

		MainPage = new AppShell();
    }


    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddSingleton(DeviceDisplay.Current);

        return services.BuildServiceProvider();
    }
}
