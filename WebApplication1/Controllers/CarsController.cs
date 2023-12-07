using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.Models;
using WebApplication1.Repositonies;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public ActionResult<List<CarDto>> GetCars()
        {
            List<CarDto> cars = new List<CarDto>();
            _carRepository.GetAll().ForEach(car =>
                cars.Add(new CarDto()
                {
                    Name = car.Name,
                    Description = car.Description,
                    DriverId = car.DriverId
                }));
            return Ok(_carRepository.GetAll());
        }

        [HttpPost]
        public ActionResult<CarDto> CreateCar([FromBody] CarDto dto)
        {
            Car car = new Car()
            {
                Name = dto.Name,
                Description = dto.Description,
                DriverId = dto.DriverId
            };
            var result = _carRepository.Create(car);
            _carRepository.SaveChanges();
            return Ok(_carRepository.Create(car));
        }
        [HttpDelete("{carId}")]
        public ActionResult<string> DeleteDriver([FromBody] int carId)
        {
            var car = _carRepository.GetById(carId);
            if (car == null)
            {
                return NotFound();
            }
            _carRepository.Delete(car);
            _carRepository.SaveChanges();
            return Ok("Успешно");
        }
    }
}
