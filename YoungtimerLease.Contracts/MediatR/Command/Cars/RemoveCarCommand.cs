namespace YoungtimerLease.Contracts.MediatR.Command.Cars;

public class RemoveCarCommand : IRequest
{
    public Guid Id { get; set; }
}
