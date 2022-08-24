using Microsoft.EntityFrameworkCore.Design;

namespace YoungtimerLease.Data;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .Build();
        return new DataContext(new DbContextOptionsBuilder<DataContext>().Options, configuration);

    }
}
