namespace SIPV_Frontend;

public partial class BencinskaPopUpPage : ContentPage
{
	public BencinskaPopUpPage()
	{
		InitializeComponent();
	}

    private async void CloseButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}