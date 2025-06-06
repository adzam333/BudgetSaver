namespace BudgetSaver.Models;

public class Event
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Today;
}
