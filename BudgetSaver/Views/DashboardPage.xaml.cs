namespace BudgetSaver.Views;

public partial class DashboardPage : ContentPage
{
    private readonly BudgetSaver.ViewModels.DashboardViewModel viewModel;

    public DashboardPage()
    {
        InitializeComponent();
        viewModel = new BudgetSaver.ViewModels.DashboardViewModel();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.LoadGoal();
    }
}
