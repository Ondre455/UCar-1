using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCar.Data.Models
{
    public class Cathegory : IEnumerable
    {
        public int ID { get; set; }
        public string CathegoryName { get; set; }
        public string gesk { get; set; }
        public List<int> CarID { get; set; }
        public IEnumerator<Car> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
