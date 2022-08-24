namespace YoungtimerLease.Domain.Model.Persistance.Interfaces
{
    public interface IQuery<T, TResult> where T : class, IEntity, new()
    {
        Task<ICustomResult<TResult>> Execute(IQueryable<T> query);
    }
}
