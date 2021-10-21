using BicycleStore.Models;
using BicycleStore.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Controllers
{
    [Authorize(Roles ="superAdmin")]
    public class UserController : Controller
    {
        BicycleContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(BicycleContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await CreateViewModel());
        }

        private async Task<List<UserInfoViewModel>> CreateViewModel()
        {
            List<UserInfoViewModel> list = new List<UserInfoViewModel>();

            foreach (var user in userManager.Users.ToList())
            {
                UserInfoViewModel usrVM = new UserInfoViewModel();
                usrVM.User = user;
                usrVM.IsAdmin = await userManager.IsInRoleAsync(user,"admin");
                if(!await userManager.IsInRoleAsync(user, "superAdmin"))
                {
                    list.Add(usrVM);
                }
            }
            return list;
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            if (await userManager.IsInRoleAsync(user, "admin"))
            {
                await userManager.RemoveFromRoleAsync(userManager.Users.Where(x => x.Id == user.Id).FirstOrDefault(), "admin");
            }
            else
            {
                await userManager.AddToRoleAsync(userManager.Users.Where(x => x.Id == user.Id).FirstOrDefault(), "admin");
            }
            return View(await CreateViewModel());
        }
    }
}
