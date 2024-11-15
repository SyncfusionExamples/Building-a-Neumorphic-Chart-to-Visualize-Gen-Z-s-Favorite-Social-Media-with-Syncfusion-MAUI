namespace GenZFavouriteSocialMedia
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SfButton_Clicked(object sender, EventArgs e)
        {
            if (App.Current != null)
            {
                if (App.Current.RequestedTheme == AppTheme.Light)
                {
                    App.Current.UserAppTheme = AppTheme.Dark;
                }
                else
                {
                    App.Current.UserAppTheme = AppTheme.Light;
                }
            }
        }
    }
}
