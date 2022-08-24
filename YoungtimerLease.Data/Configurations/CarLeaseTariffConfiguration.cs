namespace YoungtimerLease.Data.Configurations;

public class CarLeaseTariffConfiguration : IEntityTypeConfiguration<CarLeaseTariff>
{

    public void Configure(EntityTypeBuilder<CarLeaseTariff> builder)
    {
        builder.ToTable("Leasetarieven");
        builder.Property(p => p.FixedLeaseMonthPrice).HasColumnType("smallmoney");
        builder.HasCheckConstraint("tariffceckconstraint", "FixedLeaseMonthPrice is null OR CalculateTariff=0");
        builder.Navigation(p => p.LeasePeriodKilometer).AutoInclude();

        builder.HasData(CarLeaseTariffData.GetData());
    }
}
