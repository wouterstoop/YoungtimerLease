using YoungtimerLease.Contracts.MediatR.Command.Cars;
using YoungtimerLease.Contracts.MediatR.Query.Cars;

namespace YoungtimerLease.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarDTO>>> Get(bool showOnlineOnly, bool showAlsoReserved, string? make, DateTime? fromConstructionDate, DateTime? toConstructionDate, [FromQuery] Guid?[] fuelId, [FromQuery] Guid?[] driveTrainId, bool? automaticTransmission, int? fromDynamicPowerKw)
    {

        var responsCars = showOnlineOnly ?
            await _mediator.Send(new GetOnlineCarsFilterQuery
            {
                Make = make,
                ShowAlsoReserved = showAlsoReserved,
                FromConstructionDate = fromConstructionDate,
                ToConstructionDate = toConstructionDate,
                FuelId = fuelId,
                DriveTrainId = driveTrainId,
                AutomaticTransmission = automaticTransmission,
                FromDynamicPowerKw = fromDynamicPowerKw

            }) :
            await _mediator.Send(new GetAllCarsQuery());

        return Ok(responsCars);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CarDTO>> Get(Guid id)
    {
        var responseCar = await _mediator.Send(new GetCarByIdQuery { Id = id });
        return Ok(responseCar);
    }



    [HttpPut("{id:guid}")]
    public async Task<ActionResult> Put(UpdateCarCommand car, Guid id)
    {
        car.Id = id;
        await _mediator.Send(car);
        return NoContent();
    }


    [HttpPost]
    public async Task<ActionResult<Guid>> Post(AddCarCommand command)
    {
        Guid id = await _mediator.Send(command);
        return CreatedAtAction("Get", id, id);
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await _mediator.Send(new RemoveCarCommand { Id = id });
        return NoContent();
    }

}
