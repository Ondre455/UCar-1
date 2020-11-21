using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCar.Data.Models
{
    public class Car
    {
        private int id;
        public int ID { 
            get
            {
                return id;
            }
            set
            {
                id = GetHashCode();
            }
        }
        public string Name { get; set; }
        public string ShortDesk { get; set; }
        public string LongDesk { get; set; }
        public string img { get; set; }
        public ushort Price { get; set; }
        public virtual Cathegory Cathegory { get; set; }
        public List<int> CathegoryID { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
