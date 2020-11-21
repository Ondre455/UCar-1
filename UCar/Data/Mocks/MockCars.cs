using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCar.Data.Interfaces;
using UCar.Data.Models;

namespace UCar.Data.Mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}
