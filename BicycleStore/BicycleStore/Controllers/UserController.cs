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
        [Authorize(Roles = "superAdmin")]
        public async Task<IActionResult> Index()
        {
            return View(await CreateViewModel());
        }
        [Authorize(Roles = "superAdmin")]
        private async Task<List<UserInfoViewModel>> CreateViewModel()
        {
            List<UserInfoViewModel> list = new List<UserInfoViewModel>();

            foreach (var user in userManager.Users.ToList())
            {
                UserInfoViewModel usrVM = new UserInfoViewModel();
                usrVM.User = user;
                usrVM.IsAdmin = await userManager.IsInRoleAsync(user,"admin");
                list.Add(usrVM);
            }
            return list;
        }
        [Authorize(Roles = "superAdmin")]
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
        [Authorize(Roles = "superAdmin")]
        public async Task<IActionResult> Edit(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            return View(user);
        }
        [Authorize(Roles = "superAdmin")]
        [HttpPost]
        public async Task<IActionResult> Edit(EditedUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            
            if (user != null)
            {
                if (model.UserName != user.UserName && model.UserName!="admin@gmail.com")
                {
                    user.UserName = model.UserName;
                    user.Email = model.UserName;
                }
                if(model.Year != user.Year)
                {
                    user.Year = model.Year;
                }
                if (model.Pass != null)
                {
                    user.PasswordHash = userManager.PasswordHasher.HashPassword(user,model.Pass);
                }
                IdentityResult result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }
                    return View(model.UserId);
                }
                
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            string id = user.Id;
            if (user != null)
            {
                return View("ChangePassword",id);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user != null)
            {
                IdentityResult result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    user.PasswordHash = userManager.PasswordHasher.HashPassword(user, model.NewPassword);
                    await userManager.UpdateAsync(user);
                    return Redirect("/Home/Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        
                    }
                    return View("ChangePassword",model.UserId);
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
