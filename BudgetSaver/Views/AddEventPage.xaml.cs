namespace BudgetSaver.Views;

public partial class AddEventPage : ContentPage
{
    public AddEventPage()
    {
        InitializeComponent();
        BindingContext = new BudgetSaver.ViewModels.AddEventViewModel();
    }
}
