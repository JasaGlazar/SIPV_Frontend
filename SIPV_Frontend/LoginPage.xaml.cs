namespace SIPV_Frontend;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new RegistrationPage());
    }
}