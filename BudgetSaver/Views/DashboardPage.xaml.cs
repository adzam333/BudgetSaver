namespace BudgetSaver.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new BudgetSaver.ViewModels.DashboardViewModel();
    }
}
