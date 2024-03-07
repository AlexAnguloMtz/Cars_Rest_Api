using Cars.Domain;
using Cars.Dto;

namespace Cars.Service
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
