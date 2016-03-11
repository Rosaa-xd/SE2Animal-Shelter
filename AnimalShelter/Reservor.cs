using System;

namespace AnimalShelter
{
    public class Reservor
    {
        public string Name { get; private set; }
        public DateTime ReservedAt { get; private set; }

        public Reservor(string name, DateTime reservedAt)
        {
            Name = name;
            ReservedAt = reservedAt;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
