namespace YoungtimerLease.Tests;

public class CarLeaseTariffProfileTests
{
    private IMapper _sut;

    public CarLeaseTariffProfileTests()
    {
        _sut = new MapperConfiguration(c => c.AddProfile<CarLeaseTariffProfile>()).CreateMapper();
    }

    [Fact]
    public void MapperConfigurationValidation()
    {
        _sut.ConfigurationProvider.AssertConfigurationIsValid();
    }
}