using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using YoungtimerLease.Data;
using YoungtimerLease.Persistance.Exceptions;

namespace YoungtimerLease.Persistance;

public class Repository : IRepository
{
    private readonly DataContext _context;
    private readonly ILogger<IDesignTimeDbContextFactory<DbContext>> _logger;
    public Repository(DataContext context, ILogger<IDesignTimeDbContextFactory<DbContext>> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<bool> Save()
    {
        _logger.LogInformation($"Wijzigingen opslaan");
        int recordsEffected = await _context.SaveChangesAsync();
        _logger.LogInformation($"{recordsEffected} records weggeschreven");
        return recordsEffected > 0;
    }

    public void Delete<T>(T entity) where T : class, IEntity, new()
    {
        _context.Remove(entity);
    }

    public async Task<List<T>> GetAll<T>() where T : class, IEntity, new()
    {
        _logger.LogInformation($"Ophalen van alle records van {typeof(T).Name}");
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById<T>(Guid id) where T : class, IEntity, new()
    {
        _logger.LogInformation($"Ophalen van {typeof(T).Name} met Id {id}");
        return await _context.FindAsync<T>(id) ?? throw new DbRecordNotFoundException(typeof(T).Name);
    }

    public void Insert<T>(T entity) where T : class, IEntity, new()
    {
        _context.Add(entity);
    }

    public async Task<ICustomResult<TResult>> Query<T, TResult>(IQuery<T, TResult> query) where T : class, IEntity, new()
    {
        return await query.Execute(_context.Set<T>());
    }

}
