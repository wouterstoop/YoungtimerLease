using YoungtimerLease.Contracts.MediatR.Query.LeasePeriodsKilometers;

namespace YoungtimerLease.Handlers.QueryHandlers.LeasePeriodsKilometerss;

public class GetAllLeasePeriodsKilometersHandler : IRequestHandler<GetAllLeasePeriodsKilometersQuery, IEnumerable<LeasePeriodKilometerDTO>>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public GetAllLeasePeriodsKilometersHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LeasePeriodKilometerDTO>> Handle(GetAllLeasePeriodsKilometersQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll<LeasePeriodKilometer>();
        return _mapper.Map<IEnumerable<LeasePeriodKilometerDTO>>(result);
    }
}
