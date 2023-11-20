using System;

namespace AuthentiDate.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            SetWelcomeMessage();
        }

        private void SetWelcomeMessage()
        {
            DateTime now = DateTime.Now;
            string welcomeMessage = "";

            if (now.Hour >= 0 && now.Hour < 12)
            {
                welcomeMessage = "Good morning!";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                welcomeMessage = "Good afternoon!";
            }
            else
            {
                welcomeMessage = "Good evening!";
            }

            WelcomeLabel.Text = $"{welcomeMessage} Welcome to AuthentiDate!";
        }
    }
}