using YoungtimerLease.Domain.Model.Persistance.Interfaces;

namespace YoungtimerLease.Data.Configurations;

public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
{
    private string _tableName;
    public BaseConfiguration(string tableName)
    {
        _tableName = tableName;
    }

    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable(_tableName);
        builder.HasKey(k => k.Id);
        builder.Property(k => k.Id).ValueGeneratedOnAdd();
    }
}
