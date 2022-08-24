namespace YoungtimerLease.Persistance.Interfaces;

public interface IRepository
{
    Task<List<T>> GetAll<T>() where T : class, IEntity, new();
    Task<T> GetById<T>(Guid id) where T : class, IEntity, new();
    void Insert<T>(T entity) where T : class, IEntity, new();
    void Delete<T>(T entity) where T : class, IEntity, new();
    Task<ICustomResult<TResult>> Query<T, TResult>(IQuery<T, TResult> query) where T : class, IEntity, new();
    Task<bool> Save();
}
