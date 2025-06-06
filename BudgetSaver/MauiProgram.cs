using Microcharts.Maui;

namespace BudgetSaver;

public static class MauiProgram
{
        public static MauiApp CreateMauiApp()
        {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMicrocharts();

            return builder.Build();
        }
}
