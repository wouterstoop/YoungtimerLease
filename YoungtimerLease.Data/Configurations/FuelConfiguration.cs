namespace YoungtimerLease.Data.Configurations;

public class FuelConfiguration : BaseConfiguration<Fuel>, IEntityTypeConfiguration<Fuel>
{
    public FuelConfiguration() : base("Brandstoffen")
    {
    }

    public override void Configure(EntityTypeBuilder<Fuel> builder)
    {
        base.Configure(builder);
        builder.HasAlternateKey(p => p.Name);

        builder.HasData(FuelData.GetData());
    }
}
