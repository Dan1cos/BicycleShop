using BicycleStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Controllers
{
    [Authorize(Roles = "admin, superAdmin")]
    public class UserController : Controller
    {
        BicycleContext context;

        public UserController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Users.ToList());
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user.RoleId == 1) 
            {
                context.Users.Find(user.UserId).RoleId = 2;
            }
            else
            {
                context.Users.Find(user.UserId).RoleId = 1;
            }
            context.SaveChanges();
            return View(context.Users.ToList());
        }
    }
}
