using System;

namespace AnimalShelter
{
    public class Reservor: Buyer
    {
        public DateTime ReservedAt { get; private set; }

        public Reservor(string name, DateTime reservedAt)
            : base (name)
        {
            ReservedAt = reservedAt;
        }
    }
}
