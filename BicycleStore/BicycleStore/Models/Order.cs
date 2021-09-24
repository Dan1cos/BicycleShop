using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter your phone")]
        public string Phone { get; set; }
        public int? BicycleId { get; set; }
        public Bicycle Bicycle { get; set; }
    }
}
