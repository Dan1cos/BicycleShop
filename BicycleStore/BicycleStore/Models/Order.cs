using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int BicycleId { get; set; }
        public Bicycle Bicycle { get; set; }
    }
}
