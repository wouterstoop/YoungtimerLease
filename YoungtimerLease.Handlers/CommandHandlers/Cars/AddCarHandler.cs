namespace YoungtimerLease.Handlers.CommandHandlers.Cars;

public class AddCarHandler : IRequestHandler<AddCarCommand, Guid>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public AddCarHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(AddCarCommand request, CancellationToken cancellationToken)
    {
        var car = _mapper.Map<Car>(request);
        _repository.Insert(car);
        if (!await _repository.Save()) throw new Exception("Auto niet toegevoegd");
        return car.Id;
    }
}
