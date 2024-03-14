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

    //Samo klikne� na Prijava gumb pa te vr�e not
    private async void prijava_btn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new AppShell());
    }
}