using System;
using System.Collections.Generic;

#nullable disable

namespace FetchMatesClone.Models
{
    public partial class DogParkVisit
    {
        public int VisitId { get; set; }
        public int DogId { get; set; }
        public string ParkName { get; set; }
        public DateTime DayAndTime { get; set; }

        public virtual Dog Dog { get; set; }
    }
}
