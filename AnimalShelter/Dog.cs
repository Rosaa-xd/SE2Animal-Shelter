using System;

namespace AnimalShelter
{

    public class Dog : Animal
    {
        public DateTime LastWalkDay { get; private set; }

        public Dog(string name, string age, Gender gender, string isReserved, DateTime lastWalkDay)
            : base(name, age, gender, isReserved)
        {
            LastWalkDay = lastWalkDay;
        }

        public override string ToString()
        {
            return base.ToString() + LastWalkDay;
        }
    }
}
