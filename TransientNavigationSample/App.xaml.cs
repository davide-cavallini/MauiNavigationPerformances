namespace TransientNavigationSample
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new AppShell();
            Services = serviceProvider;
        }
    }
}
