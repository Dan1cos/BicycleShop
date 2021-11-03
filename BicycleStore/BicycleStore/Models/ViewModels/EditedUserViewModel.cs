using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models.ViewModels
{
    public class EditedUserViewModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}
