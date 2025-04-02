using Application10.RentalCar10.port.In;
using Application10.RentalCar10.port.Out;
using Domain10.RentalCar10;
//using Domain.Lab120240821;

namespace Application10.RentalCar10
{
    /// <summary>
    /// RentalCar 租車服務的主要 Application Services
    /// </summary>
    public class RentalCarSerAppServices
    {
        private readonly IRentalCarRepository _rentalCarRepository;
        private readonly IRentalCarUseCase _rentalCarUseCase;

        public RentalCarSerAppServices(IRentalCarRepository rentalCarRepository, IRentalCarUseCase rentalCarUseCase)
        {
            _rentalCarRepository = rentalCarRepository;
        }
        public IEnumerable<IVehicle>? GetAllCars()
        {
            return _rentalCarUseCase.GetAllCars();
        }

        public bool ToRentCar(IVehicle car)
        {
            Car mycar = new Car(car.Model) { CC = car.CC };

            return _rentalCarRepository.AddCar(car);
        }
    }
}

