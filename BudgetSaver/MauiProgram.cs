namespace BudgetSaver;

public static class MauiProgram
{
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();

            builder.Services.AddSingleton<BudgetSaver.Core.Services.IDataService, BudgetSaver.Core.Services.DataService>();
            builder.Services.AddTransient<BudgetSaver.Core.ViewModels.CounterViewModel>();

            return builder.Build();
        }
}
