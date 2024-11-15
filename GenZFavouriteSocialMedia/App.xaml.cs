namespace GenZFavouriteSocialMedia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Windows[0].Page = new MainPage();
        }
    }
}
