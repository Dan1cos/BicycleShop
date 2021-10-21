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
    public class AdminController : Controller
    {
        BicycleContext context;
        public AdminController(BicycleContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                ViewBag.Page = id;
            }
            return View(context.Bicycles.ToList());
        }

        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(context.Bicycles.FirstOrDefault(x => x.BicycleId == id));
            }
           
        }

        [HttpPost]
        public IActionResult Create(Bicycle bicycle)
        {
            if (ModelState.IsValid)
            {
                if (bicycle.BicycleId == 0 || bicycle.BicycleId == null)
                {
                    context.Bicycles.Add(bicycle);
                }
                else
                {
                    var bic = context.Bicycles.Find(bicycle.BicycleId);
                    bic.Title = bicycle.Title;
                    bic.Model = bicycle.Model;
                    bic.WDiameter = bicycle.WDiameter;
                    bic.FrameMaterial = bicycle.FrameMaterial;
                    bic.BrakeType = bicycle.BrakeType;
                    bic.Color = bicycle.Color;
                    bic.Price = bicycle.Price;
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(bicycle);
            }
        }

        [HttpPost]
        public IActionResult Delete(int bicycleId)
        {
            context.Bicycles.Remove(context.Bicycles.Find(bicycleId));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
