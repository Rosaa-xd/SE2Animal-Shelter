﻿namespace AnimalShelter
{
    public class Buyer
    {
        public string Name { get; }

        public Buyer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
