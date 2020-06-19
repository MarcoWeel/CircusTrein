using circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class WagonTests
    {
        private Wagon wagon;

        [TestInitialize]
        public void Setup()
        {
            wagon = new Wagon();
        }

        [TestMethod]
        public void Can_Create_Wagon_With_Default_SpacesLeft()
        {


            Assert.IsNotNull(wagon);
            Assert.AreEqual(10, wagon.SpacesLeft);
            Assert.AreEqual(10, wagon.MaxSpace);
        }

        [TestMethod]
        public void Can_Check_And_Add_Animal_To_Wagon_And_SpaceLeft_Lowers()
        {
            Animal animal = new Animal(AnimalSize.Large,AnimalType.Carnivore);
            int expectedSpaceLeft = wagon.MaxSpace - (int)animal.AnimalSize;

            bool canAdd = wagon.CheckAnimalAndAddToWagon(animal);

            Assert.AreEqual(expectedSpaceLeft, wagon.SpacesLeft);
            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void Cant_Add_Multiple_Carnivores_To_One_Wagon()
        {
            Animal animal1 = new Animal(AnimalSize.Middle, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Small, AnimalType.Carnivore);
            int expectedSpaceLeft = wagon.MaxSpace - (int)animal1.AnimalSize;

            wagon.CheckAnimalAndAddToWagon(animal1);
            bool canAdd = wagon.CheckAnimalAndAddToWagon(animal2);

            Assert.AreEqual(1,wagon.Animals.Count);
            Assert.AreEqual(false, canAdd);
            Assert.AreEqual(expectedSpaceLeft, wagon.SpacesLeft);
        }

        [TestMethod]
        public void Can_Add_Only_Herbivore_Into_Wagon()
        {
            Animal animal = new Animal(AnimalSize.Large, AnimalType.Herbivore);

            bool canAdd = wagon.CheckAnimalAndAddToWagon(animal);

            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void Cant_Add_More_Than_MaxSpace()
        {
            Animal animal1 = new Animal(AnimalSize.Large, AnimalType.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Large, AnimalType.Herbivore);
            Animal animal3 = new Animal(AnimalSize.Large, AnimalType.Herbivore);

            wagon.CheckAnimalAndAddToWagon(animal1);
            bool canAdd1 = wagon.CheckAnimalAndAddToWagon(animal2);
            bool canAdd2 = wagon.CheckAnimalAndAddToWagon(animal3);

            Assert.AreEqual(true, canAdd1);
            Assert.AreEqual(false, canAdd2);
        }

        [TestMethod]
        public void Can_Add_Herbivore_Bigger_Than_Carnivore_To_Wagon()
        {
            Animal animal1 = new Animal(AnimalSize.Small, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Large, AnimalType.Herbivore);

            wagon.CheckAnimalAndAddToWagon(animal1);
            bool canAdd = wagon.CheckAnimalAndAddToWagon(animal2);

            Assert.AreEqual(true, canAdd);
        }
    }
}
