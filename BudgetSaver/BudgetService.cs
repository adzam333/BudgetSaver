namespace BudgetSaver;

public class Transaction
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
}

public class BudgetService
{
    private readonly List<Transaction> _transactions = new();

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
    }

    public decimal GetTotalSavings() => _transactions.Sum(t => t.Amount);

    public decimal GetMonthlySavings(DateTime month)
    {
        var first = new DateTime(month.Year, month.Month, 1);
        var next = first.AddMonths(1);
        return _transactions.Where(t => t.Date >= first && t.Date < next).Sum(t => t.Amount);
    }

    public IEnumerable<(DateTime Start, decimal Amount)> GetWeeklySavings(DateTime start, DateTime end)
    {
        var weekStart = start.Date;
        while (weekStart <= end)
        {
            var weekEnd = weekStart.AddDays(7);
            var total = _transactions
                .Where(t => t.Date >= weekStart && t.Date < weekEnd)
                .Sum(t => t.Amount);
            yield return (weekStart, total);
            weekStart = weekEnd;
        }
    }
}
