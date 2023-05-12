using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class MarkaController : Controller
    {
        private readonly List<Marka>? _markas;

        public MarkaController()
        {
            _markas = new()
            {
                new Marka {Id = 1, Name = "BMW"},
                new Marka {Id = 2, Name = "Mercedes"},
                new Marka {Id = 3, Name = "Volvo"}
            };
        }

        public IActionResult Index()
        {
            return View(_markas);
        }
    }
}
