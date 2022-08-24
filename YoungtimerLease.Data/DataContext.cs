using Microsoft.Extensions.Logging;

namespace YoungtimerLease.Data;

public class DataContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<LeasePeriodKilometer> LeasePeriodKilometers { get; set; }
    public DbSet<Fuel> Fuels { get; set; }


    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=YoungtimerLeaseDb;Trusted_Connection=True")
            .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
            LogLevel.Information);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        modelBuilder.Entity<Car>().Navigation(p => p.CarLeaseTariffs).AutoInclude();

        modelBuilder.Entity<CarLeaseTariff>()
            .HasKey(t => new { t.CarId, t.LeasePeriodKilometerId });

        modelBuilder.Entity<CarLeaseTariff>()
            .HasOne(pt => pt.Car)
            .WithMany(p => p.CarLeaseTariffs)
            .HasForeignKey(pt => pt.CarId);

        modelBuilder.Entity<CarLeaseTariff>()
            .HasOne(pt => pt.LeasePeriodKilometer)
            .WithMany()
            .HasForeignKey(pt => pt.LeasePeriodKilometerId);

    }

}
