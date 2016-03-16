namespace AnimalShelter
{
    public enum Gender
    {
        Male,
        Female
    }

    public abstract class Animal
    {
        public string Name { get; }
        public string Age { get; }
        public Gender Gender { get; }
        public string IsReserved { get; set; } 

        public Animal(string name, string age, Gender gender, string isReserved)
        {
            Name = name;
            Age = age;
            Gender = gender;
            IsReserved = isReserved;
        }

        public override string ToString()
        {
            return Name + " " + Age + " " + Gender + " " + IsReserved + " ";
        }
    }
}
