using Cars.Domain;
using Cars.Service;
using Cars.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarController(ICarService carService) : ControllerBase
    {
        private readonly ICarService _carService = carService;

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            var car = _carService.GetById(id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }

        [HttpPost]
        public ActionResult<Car> Create(CarDto dto)
        {
            var createdCar = _carService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdCar.Id }, createdCar);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, CarDto dto)
        {
            var updatedCar = _carService.Update(id, dto);
            if (updatedCar == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAll()
        {
            return Ok(_carService.GetAll());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(string id)
        {
            var car = _carService.GetById(id);
            if (car == null)
            {
                return NotFound();
            }
            _carService.DeleteById(id);
            return NoContent();
        }
    }
}
