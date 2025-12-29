using System.Diagnostics;
using legarage360.Models;
using legarage360.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace legarage360.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Garage()
        {
            GarageViewModel garage = new GarageViewModel()
            {
                Name="Temp",
                Description="any thing",
                Img= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcAnhrepFLbiapV5yT2jhL3aoNb6vi2cgGkg&s"
            };
            return View(garage);
        }


        public IActionResult Garages()
        {
            List<GarageViewModel> mylist = new List<GarageViewModel>();



            GarageViewModel garage = new GarageViewModel()
            {
                Name = "Temp",
                Description = "any thing",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcAnhrepFLbiapV5yT2jhL3aoNb6vi2cgGkg&s"
            };

            mylist.Add(garage);

             garage = new GarageViewModel()
            {
                Name = "Temp2",
                Description = "any thing",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcAnhrepFLbiapV5yT2jhL3aoNb6vi2cgGkg&s"
            };

            mylist.Add(garage);

             garage = new GarageViewModel()
            {
                Name = "Temp3",
                Description = "any thing",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcAnhrepFLbiapV5yT2jhL3aoNb6vi2cgGkg&s"
            };

            mylist.Add(garage);

             garage = new GarageViewModel()
            {
                Name = "Temp4",
                Description = "any thing",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcAnhrepFLbiapV5yT2jhL3aoNb6vi2cgGkg&s"
            };

            mylist.Add(garage);
            return View(mylist);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
