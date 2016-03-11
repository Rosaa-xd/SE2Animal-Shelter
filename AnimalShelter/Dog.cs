using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
