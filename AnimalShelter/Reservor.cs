using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Reservor
    {
        public string Name { get; private set; }
        public DateTime ReservedAt { get; private set; }

        private List<Animal> animals; 

        public Reservor(string name, DateTime reservedAt)
        {
            Name = name;
            ReservedAt = reservedAt;
            animals = new List<Animal>();
        }
    }
}
