namespace YoungtimerLease.Domain.Model;

public class LeasePeriodKilometer : Entity
{
    public int KilometersPerYear { get; set; }
    public int LeasePeriodMonths { get; set; }
    public decimal? TariffCalculationFactor { get; set; }

}
