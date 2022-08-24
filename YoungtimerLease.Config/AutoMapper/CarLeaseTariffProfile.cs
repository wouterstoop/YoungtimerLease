namespace YoungtimerLease.Config.AutoMapper
{
    public class CarLeaseTariffProfile : Profile
    {
        public CarLeaseTariffProfile()
        {
            CreateMap<CarLeaseTariff, CarLeaseTariffDTO>().ReverseMap()
                .ForMember(d => d.Car.ReferenceTariff, o => o.Ignore());
        }
    }
}
