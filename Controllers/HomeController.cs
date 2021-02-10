using BC_IS413_Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //creates a list full of concatenate strings of restaurants to display in the view, just like in the videos 
            List<string> rlist = new List<string>();

            foreach (RankedRestaurant r in RankedRestaurant.GetRestaurants())
            {
                rlist.Add($"#{r.Rank}: {r.RestaurantName}; Best Dish: {r.FavoriteDish}; Address: {r.Address}; Phone Number: {r.Phone}; Website: {r.Website}");
            }
            return View(rlist);
        }

        //Http get for page links
        [HttpGet("AddRestaurant")]
        public IActionResult UserAdd()
        {
            return View();
        }

        //Http post for submitting the form
        [HttpPost("AddRestaurant")]
        public IActionResult UserAdd(UserRestaurant res)
        {
            if(ModelState.IsValid)
            {
                TempStorage.AddApp(res);
                return RedirectToAction("UserList");
            }
            return View();
        }

        [HttpGet("UserRecommendations")]
        public IActionResult UserList()
        {
            return View(TempStorage.App);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
