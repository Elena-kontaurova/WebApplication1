using WebApplication1.Models.Base;

namespace WebApplication1.Models
{
    public class Driver : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public List<Car> Cars { get; set; }
    }
}
