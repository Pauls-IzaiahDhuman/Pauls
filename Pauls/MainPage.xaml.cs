namespace Pauls;

public partial class MainPage : ContentPage
{
	int count = 0;
    private DateTime? date;
    public MainPage()
	{
        
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

		Navigation.PushAsync(new NewPage1());

	}



    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

