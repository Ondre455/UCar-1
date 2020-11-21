using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCar.Data.Interfaces;

namespace UCar.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars AllCars;
        private readonly ICarCathegory AllCathegories;
        public CarsController(IAllCars iAllCars, ICarCathegory iCarCathegory )
        {
            AllCars = iAllCars;
            AllCathegories = iCarCathegory;
        }
        public ViewResult List()
        {
            var cars = AllCars.Cars;
            return View(cars);
        }
    }
}
