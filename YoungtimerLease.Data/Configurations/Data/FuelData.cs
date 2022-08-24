namespace YoungtimerLease.Data.Configurations.Data;

internal static class FuelData
{
    internal static Fuel[] GetData()
    {
        return new[] {
            new Fuel { Id = new Guid("A7D71800-CEE7-4630-8888-A535EE68169A"), Name = "Petrol" },
             new Fuel { Id = new Guid("60B33EB4-A587-478B-82DB-D03FA61683E4"), Name = "Diesel" },
             new Fuel { Id = new Guid("754B46E9-5B9B-47BD-970D-8D8414E22512"), Name = "LPG" }
        };
    }
}
