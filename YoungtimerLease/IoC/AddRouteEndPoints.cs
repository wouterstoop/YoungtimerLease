using YoungtimerLease.Contracts.MediatR.Query.DriveTrains;
using YoungtimerLease.Contracts.MediatR.Query.Fuels;
using YoungtimerLease.Contracts.MediatR.Query.LeasePeriodsKilometers;

namespace YoungtimerLease.IoC
{
    public static class WebApplicationExtension
    {
        public static WebApplication AddRouteEndPoints(this WebApplication app)
        {
            app.MapGet("/leaseperiodkilometers", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetAllLeasePeriodsKilometersQuery());
                return Results.Ok(result);
            });

            app.MapGet("/fuels", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetAllFuelsQuery());
                return Results.Ok(result);
            });

            app.MapGet("/drivetrains", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetAllDriveTrainsQuery());
                return Results.Ok(result);
            });

            return app;
        }
    }
}
