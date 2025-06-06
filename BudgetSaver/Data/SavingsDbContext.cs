using Microsoft.EntityFrameworkCore;
using BudgetSaver.Models;

namespace BudgetSaver.Data;

public class SavingsDbContext : DbContext
{
    public SavingsDbContext(DbContextOptions<SavingsDbContext> options)
        : base(options)
    {
    }

    public DbSet<SavingsEvent> SavingsEvents => Set<SavingsEvent>();
}
