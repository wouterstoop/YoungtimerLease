namespace YoungtimerLease.Domain.Model;

public class CarLeaseTariff
{
    public Guid CarId { get; set; }
    public Car Car { get; set; }
    public Guid LeasePeriodKilometerId { get; set; }
    public LeasePeriodKilometer LeasePeriodKilometer { get; set; }
    public decimal? FixedLeaseMonthPrice { get; set; }
    public bool CalculateTariff { get; set; }
}
