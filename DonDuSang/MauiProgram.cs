using Microsoft.Extensions.Logging;
using DonDuSang.View;
using DonDuSang.Services;
using DonDuSang.ViewModel;

namespace DonDuSang;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<CentreDeDonService>();
        builder.Services.AddSingleton<CentresDeDonViewModel>();
        builder.Services.AddTransient<CentreDeDonDetailsViewModel>();
        builder.Services.AddTransient<DetailsPage>();
		builder.Services.AddSingleton<IMap>(Map.Default);


        return builder.Build();
	}
}
