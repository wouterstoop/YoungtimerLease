namespace YoungtimerLease.Domain.Model.Persistance.Interfaces
{
    public interface ICustomResult<T>
    {
        T SingleResult();
        IEnumerable<T> ListResult();
    }
}
