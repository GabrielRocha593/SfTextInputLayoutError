using Microsoft.Extensions.Logging;
using SfTextInputLayoutError.Interfaces;
using SfTextInputLayoutError.Services;
using Syncfusion.Maui.Core.Hosting;

namespace SfTextInputLayoutError
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<INavigationService, NavigationService>();

            return builder.Build();
        }
    }
}
