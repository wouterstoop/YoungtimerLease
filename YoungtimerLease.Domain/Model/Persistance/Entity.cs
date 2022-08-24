namespace YoungtimerLease.Domain.Model.Persistance;

public abstract class Entity : IEntity
{
    public Guid Id { get; set; }
}
