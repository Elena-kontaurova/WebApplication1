using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositonies.Base;

namespace WebApplication1.Repositonies.Impl
{
    public class DriverRepository : BaseRepository<Driver>, IDriverRepository
    {
        public DriverRepository(ApplicationContext context) : base(context) 
        {
        }
    }
}
