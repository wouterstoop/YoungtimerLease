namespace YoungtimerLease.Domain.Queries.Cars;

public class GetAllCarsAsDTOQuery : IQuery<Car, CarDTO>
{

    public GetAllCarsAsDTOQuery()
    {
    }

    public async Task<ICustomResult<CarDTO>> Execute(IQueryable<Car> query)
    {
        var result = query.Select(
       p => new CarDTO
       {
           Id = p.Id,
           Make = p.Make,
           Model = p.Model,
           Title = p.Title
       });
        return await Task.FromResult(new CustomResult<CarDTO>(result));
    }


}



