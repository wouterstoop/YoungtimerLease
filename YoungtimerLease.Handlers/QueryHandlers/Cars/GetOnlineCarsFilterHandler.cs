namespace YoungtimerLease.Handlers.QueryHandlers.Cars;

public class GetOnlineCarsFilterHandler : IRequestHandler<GetOnlineCarsFilterQuery, IEnumerable<CarDTO>>
{
    private readonly IRepository _repository;

    public GetOnlineCarsFilterHandler(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CarDTO>> Handle(GetOnlineCarsFilterQuery request, CancellationToken cancellationToken)
    {
        return (await _repository.Query(new GetOnlineCarsFilterAsDTOQuery(
            request.Make, request.ShowAlsoReserved, request.FromConstructionDate, request.ToConstructionDate,
            request.FuelId, request.DriveTrainId, request.AutomaticTransmission, request.FromDynamicPowerKw
            ))).ListResult();

    }
}
