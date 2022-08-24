namespace YoungtimerLease.Config.AutoMapper;

public class LeasePeriodKilometerProfile : Profile
{
    public LeasePeriodKilometerProfile()
    {
        CreateMap<LeasePeriodKilometer, LeasePeriodKilometerDTO>();
    }
}
