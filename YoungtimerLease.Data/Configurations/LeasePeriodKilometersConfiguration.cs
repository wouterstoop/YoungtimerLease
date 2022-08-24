namespace YoungtimerLease.Data.Configurations;

public class LeasePeriodKilometersConfiguration : BaseConfiguration<LeasePeriodKilometer>, IEntityTypeConfiguration<LeasePeriodKilometer>
{
    public LeasePeriodKilometersConfiguration() : base("LeasePeriodesKilometers")
    {
    }

    public override void Configure(EntityTypeBuilder<LeasePeriodKilometer> builder)
    {
        base.Configure(builder);
        builder.HasIndex(
            p => new { p.KilometersPerYear, p.LeasePeriodMonths }).IsUnique();

        builder.Property(p => p.TariffCalculationFactor).HasColumnType("decimal(3,2)");

        builder.HasData(LeasePeriodKilometerData.GetData());
    }
}
