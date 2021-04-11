using System;
using System.Collections.Generic;

#nullable disable

namespace FetchMates.Models
{
    public partial class Dog
    {
        public int DogId { get; set; }
        public string DogBreed { get; set; }
        public string DogName { get; set; }
        public int DogWeight { get; set; }

        public virtual DogParkVisit DogParkVisit { get; set; }
    }
}
