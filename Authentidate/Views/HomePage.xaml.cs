using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using AuthentiDate.Models;

namespace AuthentiDate.Views
{
    public partial class HomePage : TabbedPage
    {
        public ObservableCollection<Profile> Profiles { get; private set; }
        private int _currentProfileIndex = 0;

        private Profile _currentProfile;
        public Profile CurrentProfile
        {
            get => _currentProfile;
            set
            {
                _currentProfile = value;
                OnPropertyChanged(nameof(CurrentProfile)); // Notify UI of change
            }
        }

        public HomePage()
        {
            InitializeComponent();
            InitializeProfiles();
            BindingContext = this;

            // Validate Profiles collection is not empty before setting initial profile
            if (Profiles.Any())
            {
                CurrentProfile = Profiles[_currentProfileIndex];
            }

            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            SwipeCard.GestureRecognizers.Add(panGesture);
        }

        private void InitializeProfiles()
        {
            Profiles = new ObservableCollection<Profile>
            {
                // Add your profiles here
                new Profile { Name = "Noa Heutz", ImageUrl = "https://streetartcities.com/media/2/2cbe8dc2-7e8b-4743-9576-fff32d79ee11/orig.jpg" },
                new Profile { Name = "Jaymian-Lee Reinartz", ImageUrl = "https://www.rpwebdesign.nl/wp-content/uploads/2023/10/Thumnbail-1-500x500.png"},
                new Profile { Name = "Xavier Prickaerts", ImageUrl = "https://www.rpwebdesign.nl/wp-content/uploads/2023/10/IMG_6252-500x500.jpg" },
                // ... other profiles
            };
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    HandleCardMovement(e.TotalX, e.TotalY);
                    break;
                case GestureStatus.Completed:
                    HandleSwipeDirection(e.TotalX, e.TotalY);
                    break;
            }
        }

        private void HandleCardMovement(double x, double y)
        {
            SwipeCard.TranslationX = x;
            SwipeCard.TranslationY = y;
            SwipeCard.Rotation = (x / 1000) * 30; // Adjust rotation angle as needed
        }

        private void HandleSwipeDirection(double x, double y)
        {
            const double swipeThreshold = 20; // Adjust as needed for sensitivity
            if (Math.Abs(x) > swipeThreshold)
            {
                if (x > 0) // Right Swipe
                {
                    SwipeRightAction();
                }
                else // Left Swipe
                {
                    SwipeLeftAction();
                }
                LoadNextProfile();
            }
            else
            {
                ResetCardPosition();
            }
        }

        private void SwipeRightAction()
        {
            DisplayAlert("Match", "You have matched with this profile!", "OK");
        }

        private void SwipeLeftAction()
        {
            DisplayAlert("Ignore", "You have ignored this profile.", "OK");
        }

        private void OnLeftSwipeClicked(object sender, EventArgs e)
        {
            SwipeLeftAction();
            LoadNextProfile();
        }

        private void OnRightSwipeClicked(object sender, EventArgs e)
        {
            SwipeRightAction();
            LoadNextProfile();
        }

        private void OnSkipClicked(object sender, EventArgs e)
        {
            // Implement the skip logic here
            LoadNextProfile();
        }

        private void LoadNextProfile()
        {
            _currentProfileIndex++;

            if (_currentProfileIndex < Profiles.Count)
            {
                CurrentProfile = Profiles[_currentProfileIndex];
                ResetCardPosition();
            }
            else
            {
                // Optionally, you can reset the profile index to start over
                 _currentProfileIndex = 0;
                 CurrentProfile = Profiles[_currentProfileIndex];
            }
        }

        private void ResetCardPosition()
        {
            SwipeCard.TranslationX = 0;
            SwipeCard.TranslationY = 0;
            SwipeCard.Rotation = 0;
        }
    }
}
