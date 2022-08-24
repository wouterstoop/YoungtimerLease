namespace YoungtimerLease.Handlers.QueryHandlers.Cars;

public class GetCarByIdHandler : IRequestHandler<GetCarByIdQuery, CarDTO>
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public GetCarByIdHandler(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CarDTO> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById<Car>(request.Id);

        var dtoResult = _mapper.Map<CarDTO>(result);

        var path = @"\...\" + result.Make.ToLower() + result.Model.ToLower() +
            result.Id.ToString().Substring(0, 2) + ".jpg";
        if (File.Exists(path))
            dtoResult.Image = Image.Load(path)?.ToBase64String(JpegFormat.Instance);

        return dtoResult;
    }
}
