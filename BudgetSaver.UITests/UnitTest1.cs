using BudgetSaver.Core.Services;

namespace BudgetSaver.UITests;

public class Tests
{
    [Test]
    public async Task DataService_WelcomeMessage_Matches()
    {
        IDataService service = new DataService();
        var message = await service.GetWelcomeMessageAsync();
        Assert.That(message, Is.EqualTo("Welcome to BudgetSaver"));
    }
}
