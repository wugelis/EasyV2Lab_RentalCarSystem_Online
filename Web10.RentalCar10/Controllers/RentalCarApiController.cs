using Application10.RentalCar10.port.In;
using Domain10.RentalCar10;
using EasyArchitectV2Lab1.ApiControllerBase.ApiLog.Filters;
using EasyArchitectV2Lab10.ApiControllerBase10;
using EasyArchitectV2Lab10.AuthExtensions10.Filters;
using EasyArchitectV2Lab10.AuthExtensions10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Lab20240823.Controllers
{
    public class RentalCarApiController : EasyArchiectV2ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        private readonly IRentalCarUseCase _rentalCarUseCase;

        public RentalCarApiController(
            IHttpContextAccessor httpContextAccessor,
            IUserService userService,
            IRentalCarUseCase rentalCarUseCase)
            : base(httpContextAccessor, userService)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _rentalCarUseCase = rentalCarUseCase;
        }

        /// <summary>
        /// 範例程式（需要驗證）
        /// </summary>
        /// <returns></returns>
        [NeedAuthorize]
        [HttpGet]
        [Route("GetPersons")]
        [ApiLogException]
        [ApiLogonInfo]
        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await Task.FromResult(new Person[]
            {
                new Person()
                {
                    ID = 1,
                    Name = "Gelis Wu"
                }
            });
        }

        [HttpGet]
        [Route("GetAllCars")]
        [ApiLogException]
        [ApiLogonInfo]
        public async Task<IEnumerable<IVehicle>> GetAllCarsAsync()
        {
            return await Task.FromResult(_rentalCarUseCase.GetAllCars());
        }
        //[HttpPost]
        //[Route("ToRentalCar")]
        //public async Task<bool?> ToRentalCarAsync(RentalCarDto rentalCarDto)
        //{
        //    Car car = new Car(ModelType.Toyota);

        //    return await Task.FromResult( _rentalCarUseCase.ToRentCar(car));
        //}
    }

    /// <summary>
    /// 範例程式：請放置在你的 Models/Dto/VO 專案裡
    /// </summary>
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
