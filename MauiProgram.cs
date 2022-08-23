using MasterContentPageDemo.CustomControls;
using MasterContentPageDemo.ViewModels;
using MasterContentPageDemo.Views;

namespace MasterContentPageDemo;

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

        builder.Services.AddSingleton<TestPage>();
        builder.Services.AddSingleton<TestPageViewModel>();

        builder.Services.AddSingleton<TestPage1>();
        builder.Services.AddSingleton<TestPage1ViewModel>();

        return builder.Build();
	}
}
