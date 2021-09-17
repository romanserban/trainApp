using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainsController : ControllerBase
    {
        private readonly DataContext _context;
        public TrainsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Train>>> GetTrains()
        {
            var trains = await _context.Trains.ToListAsync();
            var cars = await _context.Cars.ToListAsync();
            var seats = await _context.Seats.ToListAsync();
            foreach (Train t in trains)
            {
                int i = 0;
                foreach (Car c in cars)
                {
                    int j = 0;
                    foreach (Seat s in seats)
                    {
                        if (s.Carid == c.id)
                        {
                            c.Seats[j] = s;
                        }
                    }
                    j++;
                    if (c.TrainId == t.id)
                    {
                        t.Cars[i] = c;
                    }
                }
                i++;
            }
            return trains;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Train>> GetTrain(int id)
        {
            var train = await _context.Trains.FindAsync(id);
            var cars = await _context.Cars.ToListAsync();
            var seats = await _context.Seats.ToListAsync();
            int i = 0;
            foreach (Car c in cars)
            {
                int j = 0;
                foreach (Seat s in seats)
                {
                    if (s.Carid == c.id)
                    {
                        c.Seats[j] = s;
                    }
                }
                j++;
                if (c.TrainId == train.id)
                {
                    train.Cars[i] = c;
                    i++;
                }
            }

            return train;
        }


    }
}