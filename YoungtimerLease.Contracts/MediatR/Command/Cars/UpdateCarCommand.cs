using SixLabors.ImageSharp;

namespace YoungtimerLease.Contracts.MediatR.Command.Cars;

public class UpdateCarCommand : WriteCarCommand, IRequest
{
    public Guid Id { get; set; }
    public string Photo { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid? FuelId { get; set; }
    public int? NumberOfCilinders { get; set; }
    public int? CylinderCapacity { get; set; }
    public double? DynamicPowerKw { get; set; }
    public Guid? DriveTrainId { get; set; }
    public bool? AutomaticTransmission { get; set; }
    public int? NumberOfGears { get; set; }
    public int? Doors { get; set; }
    public decimal? CatalogValue { get; set; }
    public decimal? FiscalValue { get; set; }
    public int? TopSpeed { get; set; }
    public double? Acceleration0To100 { get; set; }
    public int? Mileage { get; set; }
    public ICollection<CarLeaseTariffDTO> CarLeaseTariffs { get; set; }
    public decimal? ReferrenceTariff { get; set; }
    public bool ShowOnline { get; set; }
    public bool Reserved { get; set; }


    public Image GetImage()
    {
        var binaryImage = Convert.FromBase64String(Photo.Split(",")[1]);
        return Image.Load(binaryImage);
    }

}
