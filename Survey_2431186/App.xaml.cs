namespace Survey_2431186;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();

		MainPage = new NavigationPage(new SurveysViews());
	}
}
