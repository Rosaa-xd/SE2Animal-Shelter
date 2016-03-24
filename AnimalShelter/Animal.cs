namespace AnimalShelter
{
    public abstract class Animal : ISellable
    {
        public string Name { get; set; }
        public string Age { get; private set; }
        public Gender Gender { get; private set; }
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
