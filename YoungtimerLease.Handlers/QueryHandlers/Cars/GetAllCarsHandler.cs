namespace YoungtimerLease.Handlers.QueryHandlers.Cars;

public class GetAllCarsHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<CarDTO>>
{
    private readonly IRepository _repository;

    public GetAllCarsHandler(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CarDTO>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
    {
        return (await _repository.Query(new GetAllCarsAsDTOQuery())).ListResult();

    }
}
