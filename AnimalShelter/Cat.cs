using System.Runtime.Serialization;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        public string BadHabit { get; private set; }

        public Cat(string name, string age, Gender gender, string isReserved, decimal price, string badHabit)
            : base(name, age, gender, isReserved, price)
        {
            BadHabit = badHabit;
        }

        public override string ToString()
        {
            return base.ToString() + BadHabit;
        }
    }
}
