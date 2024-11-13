namespace ShellWithStaticInterfaceSample;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}