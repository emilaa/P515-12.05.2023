using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new()
            {
                new Model {Id = 1, Name = "M5", BrandId = 1},
                new Model {Id = 2, Name = "Gle", BrandId = 2},
                new Model {Id = 3, Name = "XC90", BrandId = 3},
            };
        }

        public IActionResult Index(int id)
        {
            if (id != null)
            {
                if (!_models.Exists(m => m.Id == id))
                {
                    return BadRequest();
                }

                return View(_models.FindAll(m => m.BrandId == id));
            }

            return View(_models);
        }
    }
}
