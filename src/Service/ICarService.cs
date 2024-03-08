using Cars.src.Domain;
using Cars.src.Dto;

namespace Cars.src.Service
{
    public interface ICarService
    {
        public Car? GetById(string id);
        public IEnumerable<Car> GetAll();
        public Car Create(CarDto dto);
        public Car Update(string id, CarDto dto);
        public void DeleteById(string id);
    }
}
