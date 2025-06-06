namespace BudgetSaver.Core.ViewModels;

public class CounterViewModel
{
    private int _count;
    private readonly BudgetSaver.Core.Services.IDataService _dataService;

    public int Count => _count;

    public CounterViewModel(BudgetSaver.Core.Services.IDataService dataService)
    {
        _dataService = dataService;
    }

    public void Increment()
    {
        _count++;
    }

    public Task<string> GetWelcomeMessageAsync()
    {
        return _dataService.GetWelcomeMessageAsync();
    }
}
