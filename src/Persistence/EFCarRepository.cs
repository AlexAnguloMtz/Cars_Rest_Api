using Cars.src.Domain;

namespace Cars.src.Persistence
{
    public class EFCarRepository(CarContext carContext) : ICarRepository
    {
        private readonly CarContext _carContext = carContext;

        public Car? GetById(string id)
        {
            return _carContext.Car.FirstOrDefault(car => car.Id == id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Car.ToList();
        }

        public Car Create(Car car)
        {
            _carContext.Car.Add(car);
            _carContext.SaveChanges();
            return car;
        }

        public Car Update(Car car)
        {
            Car? existingCar = _carContext.Car.FirstOrDefault(c => c.Id == car.Id) ?? throw new Exception("Car not found");

            existingCar.Brand = car.Brand;
            existingCar.Model = car.Model;
            existingCar.Year = car.Year;

            _carContext.SaveChanges();

            return _carContext.Car.FirstOrDefault(c => c.Id == car.Id)!;
        }

        public void DeleteById(string id)
        {
            var carToDelete = _carContext.Car.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Car not found");
            _carContext.Car.Remove(carToDelete);
            _carContext.SaveChanges();
        }

    }
}
