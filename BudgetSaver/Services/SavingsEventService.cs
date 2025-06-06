using BudgetSaver.Data;
using BudgetSaver.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetSaver.Services;

public class SavingsEventService
{
    private readonly SavingsDbContext _context;

    public SavingsEventService(SavingsDbContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    public async Task AddEventAsync(SavingsEvent savingsEvent)
    {
        _context.SavingsEvents.Add(savingsEvent);
        await _context.SaveChangesAsync();
    }

    public async Task<List<SavingsEvent>> GetEventsAsync()
    {
        return await _context.SavingsEvents.AsNoTracking().ToListAsync();
    }

    public async Task UpdateEventAsync(SavingsEvent savingsEvent)
    {
        _context.SavingsEvents.Update(savingsEvent);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEventAsync(int id)
    {
        var entity = await _context.SavingsEvents.FindAsync(id);
        if (entity != null)
        {
            _context.SavingsEvents.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
