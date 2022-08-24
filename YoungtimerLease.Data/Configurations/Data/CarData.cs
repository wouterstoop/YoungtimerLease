namespace YoungtimerLease.Data.Configurations.Data;

internal static class CarData
{
    internal static Car[] GetData()
    {
        return new[]
            {
            new Car
            {
                Id = new Guid("06379CD5-2AD7-4607-9312-C22D11AE0A27"),
                Make = "MASERATI",
                Model = "Ghibli II GT 2.0 V6 24V Biturbo",
                Doors = 2,
                CylinderCapacity = 1990,
                ConstructionDate = new DateTime(1998, 3, 1),
                DynamicPowerKw = 226,
                AutomaticTransmission = false,
                NumberOfGears = 6,
                Acceleration0To100 = 5.7,
                TopSpeed = 260,
                ShowOnline = true,
                NumberOfCilinders = 6,
                CatalogValue = 72283,
                FiscalValue = 12000,
                Mileage = 140000
            },
       new Car
       {
           Id = new Guid("35F95AD3-FF01-4DE3-A53E-DDEB59F6E5CA"),
           Make = "ALFA ROMEO",
           Model = "GT 3.2 V6 24V (Vialle LPI)",
           Doors = 2,
           CylinderCapacity = 3179,
           ConstructionDate = new DateTime(2005, 2, 14),
           DynamicPowerKw = 177,
           AutomaticTransmission = false,
           NumberOfGears = 6,
           Acceleration0To100 = 6.7,
           TopSpeed = 243,
           ShowOnline = true,
           NumberOfCilinders = 6,
           CatalogValue=45515,
           FiscalValue = 5000,
           Mileage = 195000,
           ReferenceTariff=570
       },
       new Car
       {
           Id = new Guid("8159F7F4-8629-48B0-AD9B-D055F74CAA52"),
           Make = "FERRARI",
           Model = "360 Modena 3.6 V8",
           Doors = 2,
           CylinderCapacity = 3586,
           ConstructionDate = new DateTime(2003, 1, 29),
           DynamicPowerKw = 226,
           AutomaticTransmission = false,
           NumberOfGears = 6,
           Acceleration0To100 = 4.5,
           TopSpeed = 295,
           ShowOnline = true,
           NumberOfCilinders = 8,
           CatalogValue=181480,
           FiscalValue = 20000,
           Mileage = 80000,
           ReferenceTariff = 1050
       },
       new Car
       {
           Id = new Guid("408F616C-336C-44A2-9BF1-CEB0B50C3C79"),
           Make = "ALFA ROMEO",
           Model = "8C Competizione",
           Doors = 2,
           CylinderCapacity = 4691,
           ConstructionDate = new DateTime(2007, 10, 5),
           DynamicPowerKw = 331,
           AutomaticTransmission = false,
           NumberOfGears = 6,
           Acceleration0To100 = 4.2,
           TopSpeed = 293,
           ShowOnline = true,
           NumberOfCilinders = 8,
           CatalogValue=220000,
           FiscalValue = 30000,
           Mileage = 30000,
           ReferenceTariff = 1080
       },
       new Car
       {
           Id = new Guid("C6A28ADE-280E-492A-9066-89882BEE3D88"),
           Make = "BMW",
           Model = "E63 6 Series Coupe 650i",
           Doors = 2,
           CylinderCapacity = 4799,
           ConstructionDate = new DateTime(2007, 9, 15),
           DynamicPowerKw = 270,
           AutomaticTransmission = false,
           NumberOfGears = 6,
           Acceleration0To100 = 5.4,
           TopSpeed = 250,
           ShowOnline = true,
           NumberOfCilinders = 8,
           CatalogValue=119005,
           FiscalValue = 7000,
           Mileage = 160000,
           ReferenceTariff = 690
       },
       new Car
       {
           Id = new Guid("18708AE4-8668-4748-BA5D-4BF8202D2255"),
           Make = "MASERATI",
           Model = "GranSport (Vialle LPI)",
           Doors = 2,
           CylinderCapacity = 4244,
           ConstructionDate = new DateTime(2006, 6, 25),
           DynamicPowerKw = 295,
           AutomaticTransmission = true,
           NumberOfGears = 6,
           Acceleration0To100 = 4.9,
           TopSpeed = 290,
           ShowOnline = true,
           NumberOfCilinders = 8,
           FiscalValue = 22000,
           Mileage = 130000,
           ReferenceTariff = 880
       },
       new Car
       {
           Id = new Guid("EC25D2CE-51E9-41E6-9FA9-B71CC1B6079E"),
           Make = "ALFA ROMEO",
           Model = "GT 1.9 JTD MJet 16v",
           Doors = 2,
           CylinderCapacity = 1910,
           ConstructionDate = new DateTime(2007, 3, 13),
           DynamicPowerKw = 110,
           AutomaticTransmission = false,
           NumberOfGears = 6,
           Acceleration0To100 = 9.6,
           TopSpeed = 209,
           NumberOfCilinders = 4,
           FiscalValue = 1700,
           Mileage = 190000,
           ReferenceTariff = 420
       },
        new Car
       {
           Id = new Guid("BD35E46D-04EB-465E-B399-FF3F226F952E"),
           Make = "ALFA ROMEO",
           Model = "155 1.7 ts",
           Doors = 4,
           CylinderCapacity = 1749,
           ConstructionDate = new DateTime(1994, 11, 17),
           DynamicPowerKw = 85,
           AutomaticTransmission = false,
           NumberOfGears = 5,
           Acceleration0To100 = 10.6,
           TopSpeed = 191,
           ShowOnline = true,
           NumberOfCilinders = 4,
           FiscalValue = 1500,
           Mileage = 90000,
           ReferenceTariff = 400,
           Reserved=true
       }
        };
    }
}
