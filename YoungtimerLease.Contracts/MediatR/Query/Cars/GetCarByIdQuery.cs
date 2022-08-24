namespace YoungtimerLease.Contracts.MediatR.Query.Cars;

public class GetCarByIdQuery : IRequest<CarDTO>
{
    public Guid Id { get; set; }
}
