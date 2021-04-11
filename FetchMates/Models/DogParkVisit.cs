using System;
using System.Collections.Generic;

#nullable disable

namespace FetchMates.Models
{
    public partial class DogParkVisit
    {
        public int DogId { get; set; }
        public string ParkName { get; set; }
        public DateTime DayAndTime { get; set; }

        public virtual Dog Dog { get; set; }
    }
}
