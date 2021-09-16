using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly DataContext _context;
        public CarsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetCars()
        {
            var cars = _context.Cars.ToList();
            var seats = _context.Seats.ToList();
            foreach (Car c in cars)
            {
                int i = 0;
                foreach (Seat s in seats)
                {
                    if (s.Carid == c.id)
                    {
                        c.Seats[i] = s;
                    }
                }
                i++;
            }
            return cars;

        }
    }
}