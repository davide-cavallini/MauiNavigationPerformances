namespace TransientNavigationSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Button navigationButton = (Button)sender;

            var secondPage = App.Services.GetService<SecondPage>();
            if (secondPage != null)
            {
                // the transient page is created every time and for this reason the navigayion results slow
                await Shell.Current.GoToAsync(nameof(SecondPage));
            }
        }
    }

}
