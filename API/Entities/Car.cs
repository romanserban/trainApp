using System.Collections.Generic;

namespace API.Entities
{
    public enum CarType { FisrtClass, SecondClass, Sleeping }
    public class Car
    {
        public int id { get; set; }
        public int NumberOfSeats { get; set; }

        public List<Seat> Seats { get; set; }

        public int TrainId { get; set; }
    }
}