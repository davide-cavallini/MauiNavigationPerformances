namespace ShellNavigationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // the navigation is done by the Shell
            await Shell.Current.GoToAsync("///secondpage");
        }
    }
}
