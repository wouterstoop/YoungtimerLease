namespace YoungtimerLease.Contracts.MediatR.Command.Cars;

public abstract class WriteCarCommand
{

    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime? ConstructionDate { get; set; }

}
