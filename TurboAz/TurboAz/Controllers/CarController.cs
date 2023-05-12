using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new()
            {
                new Car {
                    Id = 1,
                    Name = "Bmw M5",
                    Color = "Blue",
                    Price = 30000,
                    Year = new DateTime(2012, 5, 9, 10, 30, 0),
                    ModelId = 1
                },

                new Car {
                    Id = 2,
                    Name = "Bmw M5",
                    Color = "Red",
                    Price = 35000,
                    Year = new DateTime(2013, 5, 9, 10, 30, 0),
                    ModelId = 1
                },

                new Car {
                    Id = 3,
                    Name = "Bmw M5",
                    Color = "Magenta",
                    Price = 20000,
                    Year = new DateTime(2000, 5, 9, 10, 30, 0),
                    ModelId = 1
                },

                new Car {
                    Id = 4,
                    Name = "Mercedes Gle",
                    Color = "Black",
                    Price = 100000,
                    Year = new DateTime(2020, 5, 9, 10, 30, 0),
                    ModelId = 2
                },

                new Car {
                    Id = 5,
                    Name = "Mercedes Gle",
                    Color = "White",
                    Price = 125000,
                    Year = new DateTime(2021, 5, 9, 10, 30, 0),
                    ModelId = 2
                },

                new Car {
                    Id = 6,
                    Name = "Mercedes Gle",
                    Color = "Yellow",
                    Price = 73000,
                    Year = new DateTime(2019, 5, 9, 10, 30, 0),
                    ModelId = 2
                },

                new Car {
                    Id = 7,
                    Name = "Volvo XC40",
                    Color = "Green",
                    Price = 50000,
                    Year = new DateTime(2022, 5, 9, 10, 30, 0),
                    ModelId = 3
                },

                new Car {
                    Id = 8,
                    Name = "Volvo XC40",
                    Color = "Gray",
                    Price = 64000,
                    Year = new DateTime(2020, 5, 9, 10, 30, 0),
                    ModelId = 3
                },

                new Car {
                    Id = 9,
                    Name = "Volvo XC40",
                    Color = "Black",
                    Price = 42000,
                    Year = new DateTime(2021, 5, 9, 10, 30, 0),
                    ModelId = 3
                }
            };
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (!_cars.Exists(m => m.Id == id))
                {
                    return BadRequest();
                }

                return View(_cars.FindAll(m => m.ModelId == id));
            }

            return View(_cars);
        }

        public IActionResult Detail(int? id)
        {
            if (id != null)
            {
                if (!_cars.Exists(m => m.Id == id))
                {
                    return BadRequest();
                }

                return View(_cars.Find(m => m.Id == id));
            }

            return View(_cars);
        }
    }
}
