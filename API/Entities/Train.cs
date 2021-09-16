using System.Collections.Generic;

namespace API.Entities
{
    public class Train
    {
        public int id{ get; set; }
        public string Name { get; set; }
        public string DayOfTheWeek { get; set; }
        
        public List<Car> Cars { get; set; }
    }
}