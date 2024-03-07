using Cars.Dto;
using Cars.Domain;
using Cars.Persistence;

namespace Cars.Service.Implementations
{
    public class CarService(ICarRepository carRepository) : ICarService
    {
        private readonly ICarRepository _carRepository = carRepository;

        public Car? GetById(string id)
        {
            return _carRepository.GetById(id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _carRepository.GetAll();
        }
       
        public Car Create(CarDto dto)
        {
            Car car = DtoToCar(NewId(), dto);
            return _carRepository.Create(car);
        }

        public Car Update(string id, CarDto dto)
        {
            Car car = DtoToCar(id, dto);
            return _carRepository.Update(car);
        }

        public void DeleteById(string id)
        {
            _carRepository.DeleteById(id);
        }

        private string NewId()
        {
            return Guid.NewGuid().ToString();
        }

        private Car DtoToCar(string id, CarDto dto)
        {
            return new Car
            {
                Id = id,
                Brand = dto.Brand,
                Model = dto.Model,
                Year = dto.Year
            };
        }

    }
}
