namespace YoungtimerLease.Domain.Model;

public class Car : Entity
{
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime? ConstructionDate { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Fuel? Fuel { get; set; }
    public int? NumberOfCilinders { get; set; }
    public int? CylinderCapacity { get; set; }
    public int? DynamicPowerKw { get; set; }
    public DriveTrain? DriveTrain { get; set; }
    public bool? AutomaticTransmission { get; set; }
    public int? NumberOfGears { get; set; }
    public int? Doors { get; set; }
    public decimal? CatalogValue { get; set; }
    public decimal? FiscalValue { get; set; }
    public int? TopSpeed { get; set; }
    public double? Acceleration0To100 { get; set; }
    public int? Mileage { get; set; }
    public ICollection<CarLeaseTariff>? CarLeaseTariffs { get; set; }
    public decimal? ReferenceTariff { get; set; }
    public bool ShowOnline { get; set; }
    public bool Reserved { get; set; }
}
