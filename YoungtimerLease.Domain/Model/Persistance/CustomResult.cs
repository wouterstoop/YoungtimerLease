namespace YoungtimerLease.Domain.Model.Persistance
{
    public class CustomResult<T> : ICustomResult<T>
    {
        private readonly IEnumerable<T> _query;

        public CustomResult(IEnumerable<T> query)
        {
            _query = query;
        }

        public IEnumerable<T> ListResult()
        {
            return _query.ToList();
        }

        public T SingleResult()
        {
            return _query.Single();
        }
    }
}
