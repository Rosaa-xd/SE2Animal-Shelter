using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace AnimalShelter
{
    public abstract class Animal : ISellable
    {
        public string Name { get; set; }
        public string Age { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; }
        public string IsReserved { get; set; }
        public decimal Price { get; set; }

        protected Animal(string name, string age, Gender gender, string isReserved, decimal price)
        {
            Name = name;
            Age = age;
            Gender = gender;
            IsReserved = isReserved;
            Price = price;
        }

        public override string ToString()
        {
            if (IsReserved == null)
            {
                return Name + " " + Age + " " + Gender + " ";
            }
            return Name + " " + Age + " " + Gender + " " + IsReserved + " ";
        }
    }
}
