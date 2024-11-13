namespace ShellWithStaticInterfaceSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///SecondPage");
        }
    }

}
