using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;
using Syncfusion.Maui.Core.Hosting;

namespace MauiMopupsSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureMopups()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
		builder.Services.AddTransient<MainPage>();
		return builder.Build();
	}
}
