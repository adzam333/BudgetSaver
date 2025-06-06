using BudgetSaver.Core.Services;
using BudgetSaver.Core.ViewModels;

namespace BudgetSaver.Tests;

public class CounterViewModelTests
{
    private class MockDataService : IDataService
    {
        public Task<string> GetWelcomeMessageAsync()
        {
            return Task.FromResult("Mock Welcome");
        }
    }

    [Fact]
    public void Increment_IncreasesCount()
    {
        var vm = new CounterViewModel(new MockDataService());
        vm.Increment();
        Assert.Equal(1, vm.Count);
    }

    [Fact]
    public async Task GetWelcomeMessageAsync_ReturnsFromService()
    {
        var vm = new CounterViewModel(new MockDataService());
        var msg = await vm.GetWelcomeMessageAsync();
        Assert.Equal("Mock Welcome", msg);
    }
}
