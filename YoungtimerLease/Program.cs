using YoungtimerLease.Config.AutoMapper;
using YoungtimerLease.Contracts.MediatR.Command.Cars;
using YoungtimerLease.Data;
using YoungtimerLease.Handlers.QueryHandlers.Cars;
using YoungtimerLease.IoC;
using YoungtimerLease.Middleware;
using YoungtimerLease.Persistance;
using YoungtimerLease.Persistance.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddTransient(typeof(IRepository), typeof(Repository));
builder.Services.AddAutoMapper(typeof(CarProfile));
builder.Services.AddMediatR(typeof(GetAllCarsHandler).Assembly);
builder.Services.AddValidatorsFromAssemblyContaining<UpdateCarCommandValidator>();
builder.Services.AddCors(core => core.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:...").AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseMiddleware<ExceptionHandlerMiddleware>();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.AddRouteEndPoints();

app.Run();
