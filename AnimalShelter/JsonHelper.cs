using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelter
{
    public static class JsonHelper
    { 
        // Defining all the keys for reducing variables
        private const string CAT_KEY = "Cat";
        private const string DOG_KEY = "Dog";
        private const string NAME_KEY = "Name";
        private const string AGE_KEY = "Age";
        private const string GENDER_KEY = "Gender";
        private const string ISRESERVED_KEY = "IsReserved";
        private const string PRICE_KEY = "Price";
        private const string LASTWALKDAY_KEY = "LastWalkDay";
        private const string BADHABIT_KEY = "BadHabit";
        private const string TYPE_KEY = "Type";


        public static string ListToJson(BindingList<Animal> animals)
        {
            JArray array = new JArray();
            foreach (Animal animal in animals)
            {
                JObject obj = new JObject();

                //To save parameters
                obj[NAME_KEY] = animal.Name;
                obj[AGE_KEY] = animal.Age;
                obj[GENDER_KEY] = animal.Gender.ToString();
                obj[ISRESERVED_KEY] = animal.IsReserved;
                obj[PRICE_KEY] = animal.Price;

                if (animal is Dog)
                {
                    Dog dog = (Dog) animal;

                    obj[TYPE_KEY] = DOG_KEY;
                    obj[LASTWALKDAY_KEY] = dog.LastWalkDay;

                    //Add animal to array
                    array.Add(obj);
                }
                else if (animal is Cat)
                {
                    Cat cat = (Cat) animal;

                    obj[TYPE_KEY] = CAT_KEY;
                    obj[BADHABIT_KEY] = cat.BadHabit;

                    //Add animal to array
                    array.Add(obj);
                }
            }
            return array.ToString();
        }

        public static List<Animal> JsonToList(string json)
        {
            List<Animal> animals = new List<Animal>();
            JArray array = JArray.Parse(json);
            foreach (JObject obj in array)
            {
                if (obj[TYPE_KEY].ToString().Equals(DOG_KEY))
                {
                    animals.Add(new Dog(
                        Convert.ToString(obj[NAME_KEY]),
                        Convert.ToString(obj[AGE_KEY]),
                        (Gender)Enum.Parse(typeof(Gender), obj[GENDER_KEY].ToString()),
                        Convert.ToString(obj[ISRESERVED_KEY]),
                        Convert.ToDecimal(obj[PRICE_KEY]),
                        Convert.ToDateTime(obj[LASTWALKDAY_KEY])
                    ));
                }
                else if (obj[TYPE_KEY].ToString().Equals(CAT_KEY))
                {
                    animals.Add(new Cat(
                        Convert.ToString(obj[NAME_KEY]),
                        Convert.ToString(obj[AGE_KEY]),
                        (Gender) Enum.Parse(typeof (Gender), obj[GENDER_KEY].ToString()),
                        Convert.ToString(obj[ISRESERVED_KEY]),
                        Convert.ToDecimal(obj[PRICE_KEY]),
                        Convert.ToString(obj[BADHABIT_KEY])
                    ));
                }
            }
            return animals;
        }
    }
}
