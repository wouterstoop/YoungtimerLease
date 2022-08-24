using YoungtimerLease.Contracts.MediatR.Query.Fuels;

namespace YoungtimerLease.Handlers.QueryHandlers.Fuels;

public class GetAllFuelsHandler : IRequestHandler<GetAllFuelsQuery, IEnumerable<FuelDTO>>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public GetAllFuelsHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FuelDTO>> Handle(GetAllFuelsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll<Fuel>();
        var mapper_result = _mapper.Map<IEnumerable<FuelDTO>>(result);
        return mapper_result;
    }
}
