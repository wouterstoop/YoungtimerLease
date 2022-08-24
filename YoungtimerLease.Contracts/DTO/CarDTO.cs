namespace YoungtimerLease.Contracts.DTO;

public class CarDTO
{
    public Guid? Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime? ConstructionDate { get; set; }
    public int? ConstructionYear => ConstructionDate?.Year;
    public string Title { get; set; }
    public string Description { get; set; }
    public string FuelName { get; set; }
    public int? NumberOfCilinders { get; set; }
    public int? CylinderCapacity { get; set; }
    public int? DynamicPowerKw { get; set; }
    public string DriveTrainName { get; set; }
    public string DriveTrainAbbreviation { get; set; }
    public bool? AutomaticTransmission { get; set; }
    public string Transmission => AutomaticTransmission is bool ? AutomaticTransmission is true ? "Automatisch" : "Manueel" :
            null;
    public int? NumberOfGears { get; set; }
    public int? Doors { get; set; }
    public decimal? CatalogValue { get; set; }
    public decimal? FiscalValue { get; set; }
    public decimal? FiscalAddition => FiscalValue * 0.35m;
    public int? TopSpeed { get; set; }
    public double? Acceleration0To100 { get; set; }
    public int? Mileage { get; set; }
    public string Image { get; set; }
    public bool ShowOnline { get; set; }
    public bool Reserved { get; set; }
    public ICollection<CarLeaseTariffDTO> CarLeaseTariffs { get; set; }
    public decimal? TariffFrom { get; set; }
    public int? DynamicPowerHp => DynamicPowerKw is int ? Convert.ToInt16(DynamicPowerKw * 1.362) : null;

}
