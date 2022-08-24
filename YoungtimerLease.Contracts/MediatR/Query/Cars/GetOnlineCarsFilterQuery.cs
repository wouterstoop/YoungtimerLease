namespace YoungtimerLease.Contracts.MediatR.Query.Cars;

public class GetOnlineCarsFilterQuery : IRequest<IEnumerable<CarDTO>>
{
    public string Make { get; set; }
    public bool ShowAlsoReserved { get; set; }
    public DateTime? FromConstructionDate { get; set; }
    public DateTime? ToConstructionDate { get; set; }
    public Guid?[] FuelId { get; set; }
    public Guid?[] DriveTrainId { get; set; }
    public bool? AutomaticTransmission { get; set; }
    public int? FromDynamicPowerKw { get; set; }

}
