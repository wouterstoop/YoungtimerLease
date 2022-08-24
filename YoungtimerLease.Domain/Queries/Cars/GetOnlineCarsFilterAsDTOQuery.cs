using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace YoungtimerLease.Domain.Queries.Cars;

public class GetOnlineCarsFilterAsDTOQuery : IQuery<Car, CarDTO>
{
    private readonly string _make;
    public bool _showAlsoReserved { get; set; }
    DateTime? _fromConstructionDate { get; set; }
    DateTime? _toConstructionDate { get; set; }
    Guid?[] _fuelId { get; set; }
    Guid?[] _driveTrainId { get; set; }
    bool? _automaticTransmission { get; set; }
    int? _fromDynamicPowerKw { get; set; }

    public GetOnlineCarsFilterAsDTOQuery(string make, bool showAlsoReserved, DateTime? fromConstructionDate,
    DateTime? toConstructionDate, Guid?[] fuelId, Guid?[] driveTrainId, bool? automaticTransmission,
    int? fromDynamicPowerKw)
    {
        _make = make;
        _showAlsoReserved = showAlsoReserved;
        _fromConstructionDate = fromConstructionDate;
        _toConstructionDate = toConstructionDate;
        _fuelId = fuelId;
        _driveTrainId = driveTrainId;
        _automaticTransmission = automaticTransmission;
        _fromDynamicPowerKw = fromDynamicPowerKw;
    }

    public async Task<ICustomResult<CarDTO>> Execute(IQueryable<Car> query)
    {
        query = query.Where(p => p.ShowOnline);

        if (!string.IsNullOrEmpty(_make)) query = query.Where(p => p.Make.ToUpper() == _make.ToUpper());
        if (!_showAlsoReserved) query = query.Where(p => !p.Reserved);
        if (_fromConstructionDate is DateTime) query.Where(p => p.ConstructionDate >= _fromConstructionDate);
        if (_toConstructionDate is DateTime) query = query.Where(p => p.ConstructionDate <= _toConstructionDate);
        if (_fuelId.Count() > 0) query = query.Where(p => _fuelId.Contains(p.Fuel.Id));
        if (_driveTrainId.Count() > 0) query = query.Where(p => _driveTrainId.Contains(p.DriveTrain!.Id));
        if (_automaticTransmission is bool) query = query.Where(p => p.AutomaticTransmission == _automaticTransmission);
        if (_fromDynamicPowerKw is int) query = query.Where(p => p.DynamicPowerKw >= _fromDynamicPowerKw);

        var result = query.Select(
        p => new CarDTO
        {
            Id = p.Id,
            Make = p.Make,
            Model = p.Model,
            Title = p.Title,
            CatalogValue = p.CatalogValue,
            FiscalValue = p.FiscalValue,
            FuelName = p.Fuel!.Name,
            AutomaticTransmission = p.AutomaticTransmission,
            TariffFrom = p.CarLeaseTariffs!.Select(clt =>
             clt.CalculateTariff ? clt.Car.ReferenceTariff * clt.LeasePeriodKilometer.TariffCalculationFactor : clt.FixedLeaseMonthPrice
             ).Min(),
            DynamicPowerKw = p.DynamicPowerKw,
            Image = LoadImage(@"\...\" + p.Make.ToLower() + p.Model.ToLower() + p.Id.ToString().Substring(0, 2) + ".jpg"),
            Reserved = p.Reserved
        });
        var resultDTO = new CustomResult<CarDTO>(result);
        return await Task.FromResult(resultDTO);
    }

    private static string? LoadImage(string path)
    {
        if (!File.Exists(path)) return null;

        return Image.Load(path).ToBase64String(JpegFormat.Instance);
    }

}


