using Cars.src.Domain;

namespace Cars.src.Persistence
{
    public interface ICarRepository
    {
        public Car? GetById(string id);
        public IEnumerable<Car> GetAll();
        public Car Create(Car car);
        public Car Update(Car car);
        public void DeleteById(string id);
    }
}
