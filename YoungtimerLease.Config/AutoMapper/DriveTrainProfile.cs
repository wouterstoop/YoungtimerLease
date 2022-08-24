namespace YoungtimerLease.Config.AutoMapper
{
    public class DriveTrainProfile : Profile
    {
        public DriveTrainProfile()
        {
            CreateMap<DriveTrain, DriveTrainDTO>();
        }
    }
}
