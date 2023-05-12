using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new()
            {
                new Model {Id = 1, Name = "M5", MarkaId = 1},
                new Model {Id = 2, Name = "Gle", MarkaId = 2},
                new Model {Id = 3, Name = "XC40", MarkaId = 3},
            };
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (!_models.Exists(m => m.Id == id))
                {
                    return BadRequest();
                }

                return View(_models.FindAll(m => m.MarkaId == id));
            }

            return View(_models);
        }
    }
}
