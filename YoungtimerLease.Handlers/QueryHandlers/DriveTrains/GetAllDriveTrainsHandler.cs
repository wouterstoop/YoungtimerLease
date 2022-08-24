using YoungtimerLease.Contracts.MediatR.Query.DriveTrains;

namespace YoungtimerLease.Handlers.QueryHandlers.DriveTrains;

public class GetAllDriveTrainsHandler : IRequestHandler<GetAllDriveTrainsQuery, IEnumerable<DriveTrainDTO>>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public GetAllDriveTrainsHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DriveTrainDTO>> Handle(GetAllDriveTrainsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll<DriveTrain>();
        var mapper_result = _mapper.Map<IEnumerable<DriveTrainDTO>>(result);
        return mapper_result;
    }
}
