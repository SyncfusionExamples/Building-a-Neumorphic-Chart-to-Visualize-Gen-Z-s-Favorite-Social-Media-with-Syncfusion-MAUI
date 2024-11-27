using System.Collections.ObjectModel;

namespace GenZFavouriteSocialMedia
{
    public class SocialMediaAppInfo
    {
        public ObservableCollection<SocialMediaPlatform> ApplicationData { get; set; }

        public SocialMediaAppInfo()
        {
            ApplicationData = new ObservableCollection<SocialMediaPlatform>()
            {
                new SocialMediaPlatform() {Name = "Youtube", Popularity = 93},
                new SocialMediaPlatform() {Name = "Instagram", Popularity = 78},
                new SocialMediaPlatform() {Name = "Facebook", Popularity = 67},
                new SocialMediaPlatform() {Name = "Snapchat", Popularity = 65},
                new SocialMediaPlatform() {Name = "Tiktok", Popularity = 62},
                new SocialMediaPlatform() {Name = "Pinterest", Popularity = 45},
                new SocialMediaPlatform() {Name = "Reddit", Popularity = 44},
                new SocialMediaPlatform() {Name = "X", Popularity = 42},
                new SocialMediaPlatform() {Name = "LinkedIn", Popularity = 32},
                new SocialMediaPlatform() {Name = "WhatsApp", Popularity = 32},
                new SocialMediaPlatform() {Name = "BeReal", Popularity = 12},
            };
        }
    }
}
