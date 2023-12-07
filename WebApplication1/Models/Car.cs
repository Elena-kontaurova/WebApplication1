using WebApplication1.Models.Base;

namespace WebApplication1.Models
{
    public class Car : BaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
