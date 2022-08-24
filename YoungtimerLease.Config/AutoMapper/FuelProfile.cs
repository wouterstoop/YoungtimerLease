namespace YoungtimerLease.Config.AutoMapper
{
    public class FuelProfile : Profile
    {
        public FuelProfile()
        {
            CreateMap<Fuel, FuelDTO>();
        }
    }
}
