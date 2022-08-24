namespace YoungtimerLease.Contracts.DTO;

public class CarLeaseTariffDTO
{
    public Guid LeasePeriodKilometerId { get; set; }
    public int LeasePeriodKilometerLeasePeriodMonths { get; set; }
    public int LeasePeriodKilometerKilometersPerYear { get; set; }
    public decimal? LeasePeriodKilometerTariffCalculationFactor { get; set; }
    public decimal? CarReferenceTariff { get; set; }
    public decimal? FixedLeaseMonthPrice { get; set; }
    public bool CalculateTariff { get; set; }
    public decimal? LeaseMonthPrice => CalculateTariff ? CarReferenceTariff * LeasePeriodKilometerTariffCalculationFactor : FixedLeaseMonthPrice;
}
