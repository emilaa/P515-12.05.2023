using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Brand> _brands;

        public HomeController()
        {
            _brands = new()
            {
                new Brand {Id= 1, Name = "BMW"},
                new Brand {Id= 2, Name = "Mercedes"},
                new Brand {Id= 3, Name = "Volvo"},
            };
        }

        public IActionResult Index()
        {
            return View(_brands);
        }
    }
}
