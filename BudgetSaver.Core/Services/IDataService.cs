namespace BudgetSaver.Core.Services;

public interface IDataService
{
    Task<string> GetWelcomeMessageAsync();
}
