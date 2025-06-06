using System.Collections.ObjectModel;
using BudgetSaver.Models;

namespace BudgetSaver.ViewModels;

public class HistoryViewModel : BaseViewModel
{
    public ObservableCollection<Event> Events { get; } = new();
}
