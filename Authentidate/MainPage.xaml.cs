using AuthentiDate.Views;

namespace Authentidate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string enteredUsername = UsernameEntry.Text;
            string enteredPassword = PasswordEntry.Text;

            // Hardcoded credentials for validation
            string validUsername = "Noa Heutz";
            string validPassword = "Hoihoi098!";

            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                // Successful login, navigate to the next page or perform any desired action
                DisplayAlert("Login Successful", "Welcome, " + enteredUsername, "OK");
                // Then navigate to the next page 
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                // Invalid login, display an error message
                DisplayAlert("Login Failed", "Invalid username or password. Please try again.", "OK");
            }
        }
    }
}
