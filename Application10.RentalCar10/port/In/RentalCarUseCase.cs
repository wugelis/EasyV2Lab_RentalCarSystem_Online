using Application10.RentalCar10.port.Out;
using Domain10.RentalCar10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application10.RentalCar10.port.In
{
    /// <summary>
    /// RentalCar 租車服務的主要 UseCase Services
    /// </summary>
    public class RentalCarUseCase : IRentalCarUseCase
    {
        private readonly IRentalCarRepository _rentalCarRepository;

        public RentalCarUseCase(IRentalCarRepository rentalCarRepository)
        {
            _rentalCarRepository = rentalCarRepository;
        }
        /// <summary>
        /// 取得所有車輛
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IVehicle> GetAllCars()
        {
            return _rentalCarRepository.GetAllCars();
        }
        /// <summary>
        /// 進行車輛租用作業
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ToRentCar(IVehicle car)
        {
            throw new NotImplementedException();
        }
    }
}
