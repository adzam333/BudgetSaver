using BudgetSaver.Core.Services;

namespace BudgetSaver.Tests;

public class DataServiceTests
{
    [Fact]
    public async Task GetWelcomeMessageAsync_ReturnsExpectedString()
    {
        IDataService service = new DataService();
        var message = await service.GetWelcomeMessageAsync();
        Assert.Equal("Welcome to BudgetSaver", message);
    }
}
