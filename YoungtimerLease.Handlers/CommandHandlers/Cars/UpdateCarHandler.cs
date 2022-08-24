using FluentValidation;

namespace YoungtimerLease.Handlers.CommandHandlers.Cars;

public class UpdateCarHandler : IRequestHandler<UpdateCarCommand>
{

    private readonly IRepository _repository;
    private readonly IMapper _mapper;
    private readonly IValidator<UpdateCarCommand> _validator;

    public UpdateCarHandler(IRepository repository, IMapper mapper, IValidator<UpdateCarCommand> validator)
    {
        _repository = repository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<Unit> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
    {
        _validator.ValidateAndThrow(request);

        var car = await _repository.GetById<Car>(request.Id);

        _mapper.Map(request, car);

        await _repository.Save();


        if (!string.IsNullOrWhiteSpace(request.Photo))
        {
            var photoPath = @"\...\" + car.Make + car.Model + car.Id.ToString().Substring(0, 2);
            var photo = request.GetImage();

            if (File.Exists(photoPath))
            {
                if (!request.Photo.Equals(Image.Load(photoPath).ToBase64String(JpegFormat.Instance)))
                {
                    File.Delete(photoPath);
                    photo.Save(photoPath);
                }

            }
            else
            {
                photo.Save(photoPath);
            }
        }
        return Unit.Value;
    }
}
