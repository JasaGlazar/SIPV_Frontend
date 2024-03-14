using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;


namespace SIPV_Frontend.Views;

public partial class ProfilePage : ContentPage
{

    private bool isSettingsVisible = false;

    public ProfilePage()
	{
		InitializeComponent();
    }

    // Event handler for the "Return" button
    private void ReturnButton_Clicked(object sender, EventArgs e)
    {
        // Depending on the current visibility, decide what to do
        if (settingsLayout.IsVisible)
        {
            // If settings are visible, hide them and show the tabs
            settingsLayout.IsVisible = false;
            tabsGrid.IsVisible = true;
        }
        else
        {
            // Otherwise, perform the action you want when returning from history
            // For example, navigate to another page or perform any other action
            // Here, I'll just display an alert
            DisplayAlert("Return", "You are returning from history.", "OK");
        }
    }

    private void HistoryTabButton_Clicked(object sender, EventArgs e)
    {
        // Hide settings section and show history tab
        settingsLayout.IsVisible = false;
        tabsGrid.IsVisible = true;
    }

    private void SettingsTabButton_Clicked(object sender, EventArgs e)
    {
        // Show settings section and hide history tab
        settingsLayout.IsVisible = true;
        tabsGrid.IsVisible = false;
    }

    private async void edit_ProfilePic_btn_Clicked(object sender, EventArgs e)
    {
        var mediaFile = await MediaPicker.PickPhotoAsync();
        if (mediaFile != null)
        {
            // Get the stream of the selected image
            var stream = await mediaFile.OpenReadAsync();

            // Generate a unique file name
            string uniqueFileName = Guid.NewGuid().ToString("N") + ".jpg";

            // Save the stream to a file in the app's local storage
            var filePath = Path.Combine(FileSystem.AppDataDirectory, uniqueFileName);
            using (var fileStream = File.OpenWrite(filePath))
            {
                await stream.CopyToAsync(fileStream);
            }

            // Set the source of the Image control
            Preferences.Remove("ProfilePic");
            Preferences.Set("ProfilePic", filePath);
            profile_picture.Source = " ";
            profile_picture.Source = filePath;
        }
    }


    private async void statistics_btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Statistics());
    }


}