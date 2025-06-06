using System.Collections.ObjectModel;
using BudgetSaver.Models;
using Microsoft.Maui.Storage;

namespace BudgetSaver.ViewModels;

public class DashboardViewModel : BaseViewModel
{
    public ObservableCollection<Event> UpcomingEvents { get; } = new();

    private decimal targetAmount;
    private decimal savedAmount;

    public decimal TargetAmount
    {
        get => targetAmount;
        set => SetProperty(ref targetAmount, value);
    }

    public decimal SavedAmount
    {
        get => savedAmount;
        set => SetProperty(ref savedAmount, value);
    }

    public double GoalProgress => TargetAmount == 0 ? 0 : (double)(SavedAmount / TargetAmount);

    public DashboardViewModel()
    {
        LoadGoal();
    }

    public void LoadGoal()
    {
        TargetAmount = Preferences.Get("goal_target", 0m);
        SavedAmount = Preferences.Get("goal_saved", 0m);
        OnPropertyChanged(nameof(GoalProgress));
    }
}
