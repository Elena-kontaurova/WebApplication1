using WebApplication1.Models;
using WebApplication1.Repositonies.Base;

namespace WebApplication1.Repositonies
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        List<Car> GetByDriverId(int Id);
    }
}
