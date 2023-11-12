using Microsoft.Extensions.Logging;

namespace Calstructure
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
                    fonts.AddFont("MaterialIconsOutlined-Regular.otf");
                    fonts.AddFont("MaterialIcons-Regular.ttf");
                    fonts.AddFont("MaterialIconsRound-Regular.otf");
                    fonts.AddFont("MaterialIconsSharp-Regular.otf");
                    fonts.AddFont("MaterialIconsTwoTone-Regular.otf");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}