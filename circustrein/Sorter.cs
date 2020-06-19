using System.Collections.Generic;
using System.Linq;

namespace circustrein
{
    public class Sorter
    {
        private static List<Wagon> wagons = new List<Wagon>();
        public static List<Wagon> AnimalsToWagons(List<Animal> animalList)
        {
            wagons.Clear();
            var animals = animalList.OrderBy(animal => animal.AnimalSize).ThenBy(animal => animal.AnimalType);
            foreach (var animal in animals)
            {
                if (animal.AnimalType == AnimalType.Carnivore)
                {
                    Wagon wagon = new Wagon();
                    wagon.CheckAnimalAndAddToWagon(animal);
                    wagons.Add(wagon);
                    
                }
                else
                {
                    PlaceHerbivoreInWagon(animal);
                }
            }

            return wagons;
        }

        private static void PlaceHerbivoreInWagon(Animal animal)
        {
            foreach (var listWagon in wagons)
            {
                bool status = listWagon.CheckAnimalAndAddToWagon(animal);

                if (status == true)
                {
                    return;
                }
            }
            Wagon wagon = new Wagon();
            wagon.CheckAnimalAndAddToWagon(animal);
            wagons.Add(wagon);
        }
    }
}
