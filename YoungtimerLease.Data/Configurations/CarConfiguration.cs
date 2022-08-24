namespace YoungtimerLease.Data.Configurations;

public class CarConfiguration : BaseConfiguration<Car>, IEntityTypeConfiguration<Car>
{
    public CarConfiguration() : base("Auto's")
    {
    }

    public override void Configure(EntityTypeBuilder<Car> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.CatalogValue).HasColumnType("money");
        builder.Property(p => p.FiscalValue).HasColumnType("money");
        builder.Property(p => p.ReferenceTariff).HasColumnType("money");

        builder.HasData(CarData.GetData());

    }
}
