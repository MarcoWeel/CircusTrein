using System;
using System.Collections.Generic;
using System.Text;
using circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class SorterTests
    {
        private List<Animal> animals;
        private List<Wagon> wagons;
        private Train train;

        [TestInitialize]
        public void Setup()
        {
            animals = new List<Animal>();
            wagons = new List<Wagon>();
            train = new Train();
        }

        [TestMethod]
        public void Amount_Off_Wagons_Is_Equal_To_Expected_Amount_With_Only_Carnivores()
        {
            for (int i = 0; i < 4; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, AnimalType.Carnivore));
            }

            wagons = Sorter.AnimalsToWagons(animals);
            train.AddWagons(wagons);

            Assert.AreEqual(4, train.Wagons.Count);
            CollectionAssert.AreEquivalent(animals, train.GetAllAnimals());
        }

        [TestMethod]
        public void Amount_Off_Wagons_Is_Equal_To_Expected_Amount_With_Carnivores_And_Herbivores()
        {
            for (int i = 0; i < 4; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, AnimalType.Carnivore));
                animals.Add(new Animal(AnimalSize.Middle, AnimalType.Herbivore));
                animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));
            }

            wagons = Sorter.AnimalsToWagons(animals);
            train.AddWagons(wagons);

            Assert.AreEqual(5, wagons.Count);
            CollectionAssert.AreEquivalent(animals, train.GetAllAnimals());
        }

        [TestMethod]
        public void Amount_Off_Wagons_Is_Equal_To_Expected_Amount_With_Only_Herbivores()
        {
            for (int i = 0; i < 4; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, AnimalType.Herbivore));
                animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));
            }

            wagons = Sorter.AnimalsToWagons(animals);
            train.AddWagons(wagons);

            Assert.AreEqual(4, wagons.Count);
            CollectionAssert.AreEquivalent(animals, train.GetAllAnimals());
        }
    }
}
