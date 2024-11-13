namespace TransientNavigationSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // registration of the route for the second page
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        }
    }
}
