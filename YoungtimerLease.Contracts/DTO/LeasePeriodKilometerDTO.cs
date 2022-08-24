namespace YoungtimerLease.Contracts.DTO;

public class LeasePeriodKilometerDTO
{
    public Guid? Id { get; set; }
    public int LeasePeriodMonths { get; set; }
    public int KilometersPerYear { get; set; }
    public decimal? TariffCalculationFactor { get; set; }

}
