using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Test
{
    [TestClass]
    public class TestCat
    {
        [TestMethod]
        public void CatTestConstructor()
        {
            // Arrange
            Cat cat = new Cat("Gabby", "15", Gender.Female, null, null);

            // Act
            string catName = cat.Name;
            string catAge = cat.Age;
            Gender catGender = cat.Gender;
            string catIsReserved = cat.IsReserved;
            string catBadHabit = cat.BadHabit;

            // Assert
            Assert.AreEqual("Gabby", catName);
            Assert.AreEqual("15", catAge);
            Assert.AreEqual(Gender.Female, catGender);
            Assert.AreEqual(null, catIsReserved);
            Assert.AreEqual(null, catBadHabit);
        }

        [TestMethod]
        public void CatTestToString()
        {
            // Arrange
            Cat cat = new Cat("Harry", "17", Gender.Male, "Roos", "Stinks");

            // Act
            string catToString = cat.ToString();

            // Assert
            Assert.AreEqual("Harry 17 Male Roos Stinks", catToString);
        }
    }
}
