using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly DataContext _context;
        public ReservationsController(DataContext context)
        {
            _context = context;

        }


        [HttpPost]
        public async Task<ActionResult<Reservation>> Reserve(RegisterDto registerDto)
        {
            var r = new Reservation
            {
                CNP = registerDto.CNP,
                Name = registerDto.Name,
                Email = registerDto.Email,
                DueDate = registerDto.DueDate,
                Code = registerDto.Code,
            };
            
            _context.Reservations.Add(r);
            await _context.SaveChangesAsync();

            return r;
        }
    }
}