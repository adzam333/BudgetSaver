namespace BudgetSaver.Views;

public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();
        BindingContext = new BudgetSaver.ViewModels.HistoryViewModel();
    }
}
