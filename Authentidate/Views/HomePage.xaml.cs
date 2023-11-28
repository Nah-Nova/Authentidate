using System;
using System.Collections.ObjectModel;
using AuthentiDate.Models;

namespace AuthentiDate.Views
{
    public partial class HomePage : TabbedPage
    {
        public ObservableCollection<Profile> Profiles { get; set; }

        public HomePage()
        {
            InitializeComponent();
            SetWelcomeMessage();
            InitializeProfiles();
            BindingContext = this;
        }

        private void InitializeProfiles()
        {
            Profiles = new ObservableCollection<Profile>
            {
                 new Profile { Name = "Jordan", ImageUrl = "https://placebeard.it/640x360" },
                 new Profile { Name = "Chris", ImageUrl = "https://placebeard.it/641x360" },
                 new Profile { Name = "Pat", ImageUrl = "https://placebeard.it/642x360" },
                 new Profile { Name = "Taylor", ImageUrl = "https://placebeard.it/643x360" },
                 new Profile { Name = "Jamie", ImageUrl = "https://placebeard.it/644x360" },
                 new Profile { Name = "Morgan", ImageUrl = "https://placebeard.it/645x360" },
                 new Profile { Name = "Casey", ImageUrl = "https://placebeard.it/646x360" },
                 new Profile { Name = "Riley", ImageUrl = "https://placebeard.it/647x360" },
                 new Profile { Name = "Jordan", ImageUrl = "https://placebeard.it/648x360" },
                 new Profile { Name = "Alex", ImageUrl = "https://placebeard.it/649x360" },
            };
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

        // Event handler for the Dislike button
        private void OnDislikeClicked(object sender, EventArgs e)
        {
            // Implement your logic for Dislike action
            DisplayAlert("Action", "You disliked a profile.", "OK");
        }

        // Event handler for the Like button
        private void OnLikeClicked(object sender, EventArgs e)
        {
            // Implement your logic for Like action
            DisplayAlert("Action", "You liked a profile.", "OK");
        }

        // Event handler for the Super Like button
        private void OnSuperLikeClicked(object sender, EventArgs e)
        {
            // Implement your logic for Super Like action
            DisplayAlert("Action", "You super liked a profile.", "OK");
        }
    }
}
