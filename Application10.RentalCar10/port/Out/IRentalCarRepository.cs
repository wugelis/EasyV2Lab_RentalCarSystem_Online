//using Domain.Lab120240821;
using Domain10.RentalCar10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application10.RentalCar10.port.Out
{
    public interface IRentalCarRepository
    {
        bool AddCar(IVehicle car);
        IEnumerable<IVehicle> GetAllCars();
        bool RemoveCar(IVehicle car);
        bool UpdateCar(IVehicle car);
    }
}

