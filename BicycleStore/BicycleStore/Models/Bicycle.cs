using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class Bicycle
    {
        public int BicycleId {get; set;}
        public string Title { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int WDiameter { get; set;}
        public string FrameMaterial { get; set; }
        public string BrakeType { get; set; }
        public string Color { get; set; }
    }
}
