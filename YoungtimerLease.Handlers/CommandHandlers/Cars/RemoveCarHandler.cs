namespace YoungtimerLease.Handlers.CommandHandlers.Cars;

public class RemoveCarHandler : IRequestHandler<RemoveCarCommand>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public RemoveCarHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(RemoveCarCommand request, CancellationToken cancellationToken)
    {
        var car = await _repository.GetById<Car>(request.Id);
        _repository.Delete(car);
        if (!await _repository.Save()) throw new Exception("Auto niet verwijderd");
        return Unit.Value;
    }
}
