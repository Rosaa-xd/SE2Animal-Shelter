using System.Collections.Generic;
using System.ComponentModel;

namespace AnimalShelter
{
    public static class Webshop
    {
        //BindingList to live update listboxes
        public static BindingList<Animal> animals; 
        public static BindingList<Product> products;
        public static BindingList<Buyer> buyers;
        public static List<Dog> dogs; 

        static Webshop()
        {
            animals = new BindingList<Animal>();
            products = new BindingList<Product>();
            buyers = new BindingList<Buyer>();
            dogs = new List<Dog>();
        }
    }
}
