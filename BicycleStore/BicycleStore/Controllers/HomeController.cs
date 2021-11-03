using BicycleStore.Models;
using BicycleStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.AvailiablePages = Math.Ceiling(Convert.ToDecimal(context.Bicycles.Count())/10);
            await CreateRoles();
            if (thx != "" && Request.Headers.Count==17)
            {
                ViewBag.Thanks = thx;
            }
            if (id != null)
            {
                ViewBag.Page = id;
            }
            
            
            return View();
        }

        public IActionResult BicycleList(int page = 1,string search = "", SortType sortType = SortType.TitleAsc, string company = "all", string wheelDiameter = "all", string frameMaterial = "all", string brakeType = "all", string color = "all") 
        {
            IEnumerable<Bicycle> result = null;
            switch (sortType)
            {
                case SortType.TitleAsc:
                    result = context.Bicycles.OrderBy(x => x.Title).ToList();
                    break;
                case SortType.ModelAsc:
                    result = context.Bicycles.OrderBy(x => x.Model).ToList();
                    break;
                case SortType.PriceAsc:
                    result = context.Bicycles.OrderBy(x => x.Price).ToList();
                    break;
                default:
                    result = context.Bicycles.ToList();
                    break;
            }
            var selectListItemsCompanies = new List<string> { "all" };
            selectListItemsCompanies.AddRange(context.Bicycles.Select(x => x.Title));
            selectListItemsCompanies = selectListItemsCompanies.Distinct().ToList();
            var selectListItemsDiameters = new List<string> { "all" };
            selectListItemsDiameters.AddRange(context.Bicycles.Select(x => x.WDiameter.ToString()));
            selectListItemsDiameters = selectListItemsDiameters.Distinct().ToList();
            var selectListFrameMaterials = new List<string> { "all" };
            selectListFrameMaterials.AddRange(context.Bicycles.Select(x => x.FrameMaterial));
            selectListFrameMaterials = selectListFrameMaterials.Distinct().ToList();
            var selectListBrakeTypes = new List<string> { "all" };
            selectListBrakeTypes.AddRange(context.Bicycles.Select(x => x.BrakeType));
            selectListBrakeTypes = selectListBrakeTypes.Distinct().ToList();
            var selectListColors = new List<string> { "all" };
            selectListColors.AddRange(context.Bicycles.Select(x => x.Color));
            selectListColors = selectListColors.Distinct().ToList();
            if (company != "all")
            {
                result = result.Where(x => x.Title.ToLower() == company.ToLower());
            }
            if (wheelDiameter != "all")
            {
                result = result.Where(x => x.WDiameter.ToString() == wheelDiameter);
            }
            if (frameMaterial != "all")
            {
                result = result.Where(x => x.FrameMaterial.ToLower() == frameMaterial.ToLower());
            }
            if (brakeType != "all")
            {
                result = result.Where(x => x.BrakeType.ToLower() == brakeType.ToLower());
            }
            if (color != "all")
            {
                result = result.Where(x => x.Color.ToLower() == color.ToLower());
            }
            if (!string.IsNullOrEmpty(search))
            {
                result = result.Where(x => x.Model.ToLower().Contains(search.ToLower()));
            }
            decimal avbPages = Math.Ceiling(Convert.ToDecimal(result.Count()) / 10);
            var listResult = result.ToList();
            if (result.Count() > 10)
            {
                listResult.Clear();
                for(int i = (page-1)*10;i< (result.ToArray().Length<(page+1)*10? result.ToArray().Length:(page)*10); i++)
                {
                    listResult.Add(result.ToArray()[i]);
                }
            }
            
            return PartialView(new BicycleListViewModel
            {
                Bicycles = listResult.ToList(),
                Companies = new SelectList(selectListItemsCompanies),
                WheelDiameter = new SelectList(selectListItemsDiameters),
                BrakeType = new SelectList(selectListBrakeTypes),
                FrameMaterial = new SelectList(selectListFrameMaterials),
                Color = new SelectList(selectListColors),
                AvailiablePages = Convert.ToInt32(avbPages)
            });
            
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
