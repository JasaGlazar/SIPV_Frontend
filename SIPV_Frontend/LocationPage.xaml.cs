namespace SIPV_Frontend.Views;

public partial class LocationPage : ContentPage
{
	public LocationPage()
	{
		InitializeComponent();
	}

    private async void ShowPopupButton_Clicked(object sender, EventArgs e)
    {
        BencinskaPopUpPage popupPage = new BencinskaPopUpPage();
        await Navigation.PushModalAsync(popupPage);
    }
}