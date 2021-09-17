using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Reservation
    {
        public int id { get; set; }
        [Required]
        public string CNP { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public string DueDate { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
         public int seatId { get; set; }
        

    }
}