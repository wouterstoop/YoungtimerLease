namespace YoungtimerLease.Data.Configurations
{
    public class DriveTrainConfiguration : BaseConfiguration<DriveTrain>, IEntityTypeConfiguration<DriveTrain>
    {
        public DriveTrainConfiguration() : base("Aandrijving")
        {
        }

        public override void Configure(EntityTypeBuilder<DriveTrain> builder)
        {
            base.Configure(builder);
            builder.HasAlternateKey(p => p.Name);
            builder.HasAlternateKey(p => p.Abbreviation);
            builder.Property(p => p.Abbreviation).HasMaxLength(3);

            builder.HasData(DriveTrainData.GetData());
        }

    }
}
