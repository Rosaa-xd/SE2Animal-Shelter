using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Test
{
    [TestClass]
    public class TestDog
    {
        [TestMethod]
        public void DogTestConstructor()
        {
            // Arrange
            Dog dog = new Dog("Bobby", "4", Gender.Male, null,0, new DateTime(2016, 3, 16));
            
            // Act
            string dogName = dog.Name;
            string dogAge = dog.Age;
            Gender dogGender = dog.Gender;
            string dogIsReserved = dog.IsReserved;
            DateTime dogLastWalkDay = dog.LastWalkDay;

            // Assert
            Assert.AreEqual("Bobby", dogName);
            Assert.AreEqual("4", dogAge);
            Assert.AreEqual(Gender.Male, dogGender);
            Assert.AreEqual(null, dogIsReserved);
            Assert.AreEqual(new DateTime(2016, 3, 16), dogLastWalkDay);
        }

        [TestMethod]
        public void DogTestToString()
        {
            // Arrange
            Dog dog = new Dog("Bobby", "4", Gender.Male, null,0, new DateTime(2016, 3, 16));

            // Act
            string dogToString = dog.ToString();

            // Assert
            Assert.AreEqual("Bobby 4 Male 16-03-2016", dogToString);           
        }
    }
}
