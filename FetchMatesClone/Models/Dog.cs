using System;
using System.Collections.Generic;

#nullable disable

namespace FetchMatesClone.Models
{
    public partial class Dog
    {
        public Dog()
        {
            DogParkVisits = new HashSet<DogParkVisit>();
        }

        public int DogId { get; set; }
        public string DogBreed { get; set; }
        public string DogName { get; set; }
        public int DogWeight { get; set; }

        public virtual ICollection<DogParkVisit> DogParkVisits { get; set; }
    }
}
