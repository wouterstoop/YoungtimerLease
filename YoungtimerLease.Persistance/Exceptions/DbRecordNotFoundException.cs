namespace YoungtimerLease.Persistance.Exceptions;
public class DbRecordNotFoundException : Exception
{
    public DbRecordNotFoundException(string message) : base(message)
    {
    }
}

