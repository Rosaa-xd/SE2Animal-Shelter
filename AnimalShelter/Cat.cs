using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        public string BadHabit { get; private set; }

        public Cat(string name, string age, Gender gender, string isReserved, string badHabit)
            : base(name, age, gender, isReserved)
        {
            BadHabit = badHabit;
        }
    }
}
