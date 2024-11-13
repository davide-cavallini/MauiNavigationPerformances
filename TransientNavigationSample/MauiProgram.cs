using Microsoft.Extensions.Logging;

namespace TransientNavigationSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // registration of the route for the second page
            // the second page is registered as a transient page
            builder.Services.AddTransient<SecondPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            var app = builder.Build();
            App.Services = app.Services;

            return builder.Build();
        }
    }
}
