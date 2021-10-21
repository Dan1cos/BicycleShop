using BicycleStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Controllers
{
    public class HomeController : Controller
    {
        BicycleContext context;
        private readonly RoleManager<IdentityRole> roleManager;

        public HomeController(BicycleContext context, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index(int? id, string thx = "")
        {
            await CreateRoles();
            if (thx != "" && Request.Headers.Count==17)
            {
                ViewBag.Thanks = thx;
            }
            if (id != null)
            {
                ViewBag.Page = id;
            }
            var bicycles = context.Bicycles.ToList();
            return View(bicycles);
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.BicycleId = id;
            ViewBag.Bicycle = context.Bicycles.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Buy(Order order)
        {
            if(ModelState.IsValid)
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return RedirectToAction("Index", new { thx = "Thank you for purchase!" });
            }
            else
            {
                ViewBag.BicycleId = order.BicycleId;
                ViewBag.Bicycle = context.Bicycles.Find(order.BicycleId);
                return View(order);
            }
            
        }

        public async Task CreateRoles()
        {
            if (!roleManager.Roles.Where(x => x.Name == "user").Any())
            {
                var userRole = await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (!roleManager.Roles.Where(x => x.Name == "admin").Any())
            {
                var adminRole = await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (!roleManager.Roles.Where(x => x.Name == "superAdmin").Any())
            {
                var superAdminRole = await roleManager.CreateAsync(new IdentityRole("superAdmin"));
            }
        }

        
    }
}
