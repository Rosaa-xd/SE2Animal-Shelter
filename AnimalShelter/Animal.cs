using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Animal
    {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public Gender Gender { get; private set; }
        public string IsReserved { get; private set; } 

        public Animal(string name, string age, Gender gender, string isReserved)
        {
            Name = name;
            Age = age;
            Gender = gender;
            IsReserved = isReserved;
        }
    }
}
