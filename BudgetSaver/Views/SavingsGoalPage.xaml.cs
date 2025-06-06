namespace BudgetSaver.Views;

public partial class SavingsGoalPage : ContentPage
{
    public SavingsGoalPage()
    {
        InitializeComponent();
        BindingContext = new BudgetSaver.ViewModels.SavingsGoalViewModel();
    }
}
