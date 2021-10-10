using BicycleStore.Models;
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

        public HomeController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index(int? id, string thx = "")
        {
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
    }
}
