using Microcharts;
using Microcharts.Maui;
using SkiaSharp;

namespace BudgetSaver;

public partial class MainPage : ContentPage
{
    private readonly BudgetService _budgetService = new();

    public MainPage()
    {
        InitializeComponent();
        SeedSampleData();
        UpdateDisplay();
    }

    private void SeedSampleData()
    {
        var now = DateTime.Now;
        var rnd = new Random(0);
        for (int i = 0; i < 30; i++)
        {
            var amount = rnd.Next(-50, 100);
            _budgetService.AddTransaction(new Transaction { Date = now.AddDays(-i), Amount = amount });
        }
    }

    private void UpdateDisplay()
    {
        TotalSavingsLabel.Text = $"Total Savings: {_budgetService.GetTotalSavings():C}";
        MonthlySavingsLabel.Text = $"This Month: {_budgetService.GetMonthlySavings(DateTime.Now):C}";

        var start = DateTime.Now.AddDays(-28);
        var end = DateTime.Now;
        var weekly = _budgetService.GetWeeklySavings(start, end).ToList();

        var entries = weekly.Select(w => new ChartEntry((float)w.Amount)
        {
            Label = w.Start.ToString("MM-dd"),
            ValueLabel = w.Amount.ToString("C"),
            Color = w.Amount >= 0 ? SKColor.Parse("#77d065") : SKColor.Parse("#b455b6")
        }).ToArray();

        SavingsChart.Chart = new LineChart { Entries = entries };
    }
}
