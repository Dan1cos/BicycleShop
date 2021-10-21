using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models.ViewModels
{
    public class UserInfoViewModel
    {
        public User User { get; set; }
        public bool IsAdmin { get; set; }
    }
}
