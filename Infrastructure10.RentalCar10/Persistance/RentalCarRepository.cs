using Application10.RentalCar10.port.Out;
using Domain10.RentalCar10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure10.RentalCar10.Persistance
{
    public class RentalCarRepository : IRentalCarRepository
    {
        private static List<IVehicle> _cars = new List<IVehicle>(
            new IVehicle[]
            {
                new Car(ModelType.BMW) { CC = "2.0", CarModelName = "X"},
                new Car(ModelType.Benz) { CC = "3.0", CarModelName = "AClass"},
                new Car(ModelType.Ford) { CC = "1.8", CarModelName = "Mondel" },
                new Car(ModelType.Toyota)  { CC = "2.0", CarModelName = "Camry"},
                new RV(ModelType.BMW)  { CC = "3.5", CarModelName = "X5"},
                new RV(ModelType.Benz)  { CC = "2.0", CarModelName = "Test"},
                new RV(ModelType.Ford) { CC = "2.0", CarModelName = "Kuga"},
                new RV(ModelType.Toyota) { CC = "1.8", CarModelName = "Altis"},
            }
            );
        public bool AddCar(IVehicle car)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetAllCars()
        {
            return _cars;
        }

        public bool RemoveCar(IVehicle car)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCar(IVehicle car)
        {
            throw new NotImplementedException();
        }
    }
}
