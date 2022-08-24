namespace YoungtimerLease.Data.Configurations.Data
{
    internal static class DriveTrainData
    {
        internal static DriveTrain[] GetData()
        {
            return new[]{
                new DriveTrain { Id = new Guid("F0D82820-6547-40B2-87C0-3A8EE62B6CB9"), Name = "Rear-wheel drive", Abbreviation = "RWD" },
                new DriveTrain { Id = new Guid("4D99C733-29A4-4062-9838-07331F28B3F2"), Name = "Front-wheel drive", Abbreviation = "FWD" },
                new DriveTrain { Id = new Guid("27D0A389-5F93-4DCE-B7E8-4CD85E2B7D51"), Name = "All-wheel drive", Abbreviation = "AWD" }
            };
        }
    }
}
