using System.Windows.Input;
using Microsoft.Maui.Storage;

namespace BudgetSaver.ViewModels;

public class SavingsGoalViewModel : BaseViewModel
{
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

    public ICommand SaveCommand { get; }

    public SavingsGoalViewModel()
    {
        targetAmount = Preferences.Get("goal_target", 0m);
        savedAmount = Preferences.Get("goal_saved", 0m);
        SaveCommand = new Command(OnSave);
    }

    private void OnSave()
    {
        Preferences.Set("goal_target", TargetAmount);
        Preferences.Set("goal_saved", SavedAmount);
    }
}
