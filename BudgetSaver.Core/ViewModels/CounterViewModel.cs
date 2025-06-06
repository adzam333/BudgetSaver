using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BudgetSaver.Core.ViewModels;

public class CounterViewModel : INotifyPropertyChanged
{
    private int _count;
    private readonly BudgetSaver.Core.Services.IDataService _dataService;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int Count
    {
        get => _count;
        private set
        {
            if (_count != value)
            {
                _count = value;
                OnPropertyChanged();
            }
        }
    }

    public CounterViewModel(BudgetSaver.Core.Services.IDataService dataService)
    {
        _dataService = dataService;
    }

    public void Increment()
    {
        Count++;
    }

    public Task<string> GetWelcomeMessageAsync()
    {
        return _dataService.GetWelcomeMessageAsync();
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
