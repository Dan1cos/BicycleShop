using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class Bicycle
    {
        public int? BicycleId {get; set;}
        [Required(ErrorMessage ="Enter bike title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Enter bike model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Enter bike price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Enter bike wheel diameter")]
        public int WDiameter { get; set;}
        [Required(ErrorMessage = "Enter bike frame material")]
        public string FrameMaterial { get; set; }
        [Required(ErrorMessage = "Enter bike brake type")]
        public string BrakeType { get; set; }
        [Required(ErrorMessage = "Enter bike color")]
        public string Color { get; set; }
    }
}
