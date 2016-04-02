using System;
using System.Runtime.Serialization;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        public DateTime LastWalkDay { get; private set; }

        public Dog(string name, string age, Gender gender, string isReserved, decimal price, DateTime lastWalkDay)
            : base(name, age, gender, isReserved, price)
        {
            LastWalkDay = lastWalkDay;
        }

        public override string ToString()
        {
            return base.ToString() + LastWalkDay.ToString("dd-MM-yyyy");
        }
    }
}
