using YoungtimerLease.Contracts.MediatR.Command.Cars;
using YoungtimerLease.Domain.Model;

namespace YoungtimerLease.Tests;

public class CarProfileTests
{
    private readonly MapperConfiguration _carMapperConfiguration;
    private readonly MapperConfiguration _carLeaseTariffProfileConfiguration;
    private readonly MapperConfiguration _fuelProfileConfiguration;
    private readonly MapperConfiguration _driveTrainProfileConfiguration;
    private readonly MapperConfiguration _leasePeriodKilometerProfileConfiguration;

    public CarProfileTests()
    {
        _carLeaseTariffProfileConfiguration = new MapperConfiguration(c =>
        {
            c.AddProfile<CarLeaseTariffProfile>();
            c.AddProfile<LeasePeriodKilometerProfile>();
        }
      );
        _carMapperConfiguration = new MapperConfiguration(c =>
        {
            c.AddProfile<CarProfile>();
            c.AddProfile<FuelProfile>();
            c.AddProfile<DriveTrainProfile>();
        }
        );


        _fuelProfileConfiguration = new MapperConfiguration(c => c.AddProfile<FuelProfile>());
        _driveTrainProfileConfiguration = new MapperConfiguration(c => c.AddProfile<DriveTrainProfile>());
        _leasePeriodKilometerProfileConfiguration = new MapperConfiguration(c => c.AddProfile<LeasePeriodKilometerProfile>());
    }

    [Fact]
    public void MapperConfigurationValidation()
    {
        _carProfileConfiguration.AssertConfigurationIsValid();
        _carLeaseTariffProfileConfiguration.AssertConfigurationIsValid();
        _fuelProfileConfiguration.AssertConfigurationIsValid();
        _driveTrainProfileConfiguration.AssertConfigurationIsValid();
        _leasePeriodKilometerProfileConfiguration.AssertConfigurationIsValid();
    }

    [Fact]
    public void UpdateCarCommandToCar_ItShouldPass()
    {
        var sut = _carLeaseTariffProfileConfiguration.CreateMapper();

        var source = new UpdateCarCommand();
        var expectedDestination = new Car();
        var destination = sut.Map<Car>(source);

        Assert.Equal(expectedDestination, destination);
    }

}