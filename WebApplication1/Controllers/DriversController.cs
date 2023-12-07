using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.Models;
using WebApplication1.Repositonies;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;

        public DriversController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        [HttpGet]
        public ActionResult<List<DriverDto>> GetDrivers() 
        {
            List<DriverDto>drivers = new List<DriverDto>();
            _driverRepository.GetAll().ForEach(driver =>
                drivers.Add(new DriverDto()
                {
                    Name = driver.Name,
                    Surname = driver.Surname,
                    Patronymic = driver.Patronymic
                }));
            return Ok(_driverRepository.GetAll());
        }

        [HttpPost]
        public ActionResult<DriverDto> CreateDriver([FromBody] DriverDto dto)
        {
            Driver driver = new Driver()
            { 
                Name = dto.Name,
                Surname = dto.Surname,
                Patronymic = dto.Patronymic
            };
            var result = _driverRepository.Create(driver);
            _driverRepository.SaveChanges();
            return Ok(_driverRepository.Create(driver));
        }
        [HttpDelete("{driverId}")]
        public ActionResult<string> DeleteDriver([FromBody]int driverId) 
        {
            var driver = _driverRepository.GetById(driverId);
            if (driver == null)
            {
                return NotFound();
            }
            _driverRepository.Delete(driver);
            _driverRepository.SaveChanges();
            return Ok("Успешно");
        }
    }
}
