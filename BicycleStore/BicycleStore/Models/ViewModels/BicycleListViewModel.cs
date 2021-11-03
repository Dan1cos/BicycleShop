using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models.ViewModels
{
    public class BicycleListViewModel
    {
        public List<Bicycle> Bicycles { get; set; }
        public SelectList Companies { get; set; }
        public SelectList WheelDiameter { get; set; }
        public SelectList FrameMaterial { get; set; }
        public SelectList BrakeType { get; set; }
        public SelectList Color { get; set; }
        public int AvailiablePages { get; set; }
    }
}
