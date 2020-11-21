using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCar.Data.Models;

namespace UCar.Data.Interfaces
{
    public interface ICarCathegory
    {
        IEnumerable<Cathegory> AllCathegories { get; }
    }
}
