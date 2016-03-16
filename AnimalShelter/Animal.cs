namespace AnimalShelter
{
    public enum Gender
    {
        Male,
        Female
    }

    public abstract class Animal
    {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public Gender Gender { get; private set; }
        public string IsReserved { get; set; } 

        protected Animal(string name, string age, Gender gender, string isReserved)
        {
            Name = name;
            Age = age;
            Gender = gender;
            IsReserved = isReserved;
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
