﻿using Microsoft.Extensions.Logging;

namespace MauiHybridWebView;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiHandlers(handlers => { })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
        builder.Services.AddHybridWebViewDeveloperTools();
        builder.Services.AddLogging(configure => configure.AddDebug());
#endif

        return builder.Build();
    }
}