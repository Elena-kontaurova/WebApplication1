using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositonies.Base;

namespace WebApplication1.Repositonies.Impl
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(ApplicationContext context) : base(context) 
        { 
        }
        public List<Car> GetByDriverId(int id)
        {
            return _context.Cars.ToList().FindAll(car => car.DriverId == id);
        }
    }
}
