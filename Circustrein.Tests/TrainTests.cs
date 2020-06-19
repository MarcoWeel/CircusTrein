using System;
using System.Collections.Generic;
using System.Text;
using circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class TrainTests
    {
        private Train train;
        [TestInitialize]
        public void Setup()
        {
            train = new Train();
        }

        [TestMethod]
        public void Can_Add_Wagons_To_Train()
        {
            List<Wagon> wagons = new List<Wagon>();
            for (int i = 0; i < 10; i++)
            {
                wagons.Add(new Wagon());
            }

            train.AddWagons(wagons);

            Assert.AreEqual(10, train.Wagons.Count);
        }

        [TestMethod]
        public void Can_Clear_List_Of_Wagons()
        {
            List<Wagon> wagons = new List<Wagon>();
            for (int i = 0; i < 10; i++)
            {
                wagons.Add(new Wagon());
            }
            train.AddWagons(wagons);

            train.ClearWagonList();

            Assert.AreEqual(0, train.Wagons.Count);
        }
    }
}
