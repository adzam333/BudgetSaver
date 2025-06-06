namespace BudgetSaver.Core.Services;

public class DataService : IDataService
{
    public Task<string> GetWelcomeMessageAsync()
    {
        return Task.FromResult("Welcome to BudgetSaver");
    }
}
