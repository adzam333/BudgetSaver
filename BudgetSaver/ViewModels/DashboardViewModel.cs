using System.Collections.ObjectModel;
using BudgetSaver.Models;

namespace BudgetSaver.ViewModels;

public class DashboardViewModel : BaseViewModel
{
    public ObservableCollection<Event> UpcomingEvents { get; } = new();
}
