using System.IO;
using BudgetSaver.Data;
using BudgetSaver.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Storage;

namespace BudgetSaver;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>();

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "savings.db");
        builder.Services.AddDbContext<SavingsDbContext>(options =>
            options.UseSqlite($"Filename={dbPath}"));
        builder.Services.AddTransient<SavingsEventService>();

        return builder.Build();
    }
}
