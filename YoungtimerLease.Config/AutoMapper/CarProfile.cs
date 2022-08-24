using YoungtimerLease.Contracts.MediatR.Command.Cars;

namespace YoungtimerLease.Config.AutoMapper;

public class CarProfile : Profile
{
    public CarProfile()
    {
        CreateMap<Car, CarDTO>();
        CreateMap<AddCarCommand, Car>();
        CreateMap<UpdateCarCommand, Car>()
            .ForMember(d => d.Fuel, o =>
            {
                o.Condition(s => s.FuelId is Guid);
                o.MapFrom(s => new Fuel { Id = (Guid)s.FuelId! });
            })
             .ForMember(d => d.DriveTrain, o =>
              {
                  o.Condition(s => s.DriveTrainId is Guid);
                  o.MapFrom(s => new DriveTrain { Id = (Guid)s.DriveTrainId! });
              });

    }
}
