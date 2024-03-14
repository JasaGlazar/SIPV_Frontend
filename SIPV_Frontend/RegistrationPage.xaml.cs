namespace SIPV_Frontend;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPage());
    }

    private async void naprej_btn_Clicked(object sender, EventArgs e)
    {
        string password = pass_entry.Text;
        string confirmPassword = confirm_pass_entry.Text;
        string username = username_entry.Text;

        if (password != confirmPassword)
        {

            await App.Current.MainPage.DisplayAlert("Opozorilo", "Gesla se ne ujemata", "OK");
            return;
        }

        try
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            string filePath = Path.Combine(directoryPath, "uporabniki.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(username + "," + password); 
                writer.Close();
            }

            await App.Current.MainPage.DisplayAlert("Obvestilo", "Uspešno registrirano", "OK");
        }
        catch (Exception ex)
        {
            await App.Current.MainPage.DisplayAlert("Opozorilo", "Error", "OK");
        }
    }
}