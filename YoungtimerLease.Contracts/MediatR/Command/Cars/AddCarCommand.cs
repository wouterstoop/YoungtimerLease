namespace YoungtimerLease.Contracts.MediatR.Command.Cars;

public class AddCarCommand : WriteCarCommand, IRequest<Guid>
{
}
