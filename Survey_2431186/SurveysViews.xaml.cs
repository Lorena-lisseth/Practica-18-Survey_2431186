namespace Survey_2431186;

public partial class SurveysViews : ContentPage
{
	public SurveysViews()
	{
		InitializeComponent();
		MessagingCenter.Subscribe<ContentPage, Survey>(this, Messages.NewSurveyComplete, (sender, args) =>
		{ SurveysPanel.Children.Add(new Label() { Text = args.ToString() });});
	}

	private async void AddSurveyButton_Clicked(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SurveyDetailsView());
	}

}