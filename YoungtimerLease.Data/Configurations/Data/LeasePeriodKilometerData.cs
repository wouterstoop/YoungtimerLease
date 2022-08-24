namespace YoungtimerLease.Data.Configurations.Data;

internal static class LeasePeriodKilometerData
{
    internal static LeasePeriodKilometer[] GetData()
    {
        return new[]
        {
            new LeasePeriodKilometer
            { Id = new Guid("B7894C6A-2258-4AA0-8F33-22CF276214E1"), LeasePeriodMonths = 12, KilometersPerYear = 10000, TariffCalculationFactor = 1
            },
            new LeasePeriodKilometer
            { Id = new Guid("FA5C3D42-A363-4FA6-A404-95A5B2D4FC7B"), LeasePeriodMonths = 12, KilometersPerYear = 20000, TariffCalculationFactor = 1.3m
            },
            new LeasePeriodKilometer
            { Id = new Guid("02C68411-CE8B-49CE-94B4-B31951C37FAB"), LeasePeriodMonths = 12, KilometersPerYear = 30000, TariffCalculationFactor = 1.5m
            },
            new LeasePeriodKilometer
            { Id = new Guid("66773E7A-EC64-4A17-B81F-1F7AEAF78082"), LeasePeriodMonths = 12, KilometersPerYear = 40000, TariffCalculationFactor = 1.7m
            },
            new LeasePeriodKilometer
            { Id = new Guid("E61134AB-9F8A-44F1-B38C-AA024D05EF06"), LeasePeriodMonths = 24, KilometersPerYear = 10000, TariffCalculationFactor = 0.95m
            },
            new LeasePeriodKilometer
            { Id = new Guid("89BD1AA2-4684-4E29-A3AA-A8A0BAAAD75B"), LeasePeriodMonths = 24, KilometersPerYear = 20000, TariffCalculationFactor = 1.235m
            },
            new LeasePeriodKilometer
            { Id = new Guid("AC7F24F6-FBC2-45F0-8B73-617945BCE633"), LeasePeriodMonths = 24, KilometersPerYear = 30000, TariffCalculationFactor = 1.425m
            },
            new LeasePeriodKilometer
            { Id = new Guid("976A427F-C133-4068-ABE9-7BAA3E85E2B5"), LeasePeriodMonths = 24, KilometersPerYear = 40000, TariffCalculationFactor = 1.615m
            },
            new LeasePeriodKilometer
            { Id = new Guid("5664EA11-60FF-4FF4-ABCE-99247BB655BD"), LeasePeriodMonths = 36, KilometersPerYear = 10000, TariffCalculationFactor = 0.9m
            },
            new LeasePeriodKilometer
            { Id = new Guid("231898B4-2C78-45E9-BEBE-0698BD83468D"), LeasePeriodMonths = 36, KilometersPerYear = 20000, TariffCalculationFactor = 1.17m
            },
            new LeasePeriodKilometer
            { Id = new Guid("FEC6D349-05A1-4992-9748-D2AB62FE742D"), LeasePeriodMonths = 36, KilometersPerYear = 30000, TariffCalculationFactor = 1.35m
            },
            new LeasePeriodKilometer
            { Id = new Guid("4021BC38-0535-4F5C-954B-396B677ABEEC"), LeasePeriodMonths = 48, KilometersPerYear = 10000
            },
            new LeasePeriodKilometer
            { Id = new Guid("759E7365-B2BB-4639-A628-F5084A140164"), LeasePeriodMonths = 48, KilometersPerYear = 20000
            }
        };
    }
}
