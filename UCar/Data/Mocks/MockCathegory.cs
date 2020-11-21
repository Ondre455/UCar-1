using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCar.Data.Interfaces;
using UCar.Data.Models;

namespace UCar.Data.Mocks
{
    public class MockCathegory : ICarCathegory
    {
        public IEnumerable<Cathegory> AllCathegories
        {
            get
            {
                return new List<Cathegory> { new Cathegory { CathegoryName = "Krossover" } };
            }
        }
    }
}
