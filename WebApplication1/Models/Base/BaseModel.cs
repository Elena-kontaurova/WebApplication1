using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Base
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
