using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Wagon
    {
        private List<Animal> animals;
        public IReadOnlyCollection<Animal> Animals
        {
            get
            { return animals.AsReadOnly(); }
        }

        public int SpacesLeft => MaxSpace - animals.Sum(animal => (int) animal.AnimalSize);
        public int MaxSpace { get; } = 10;

        public int ThreatLevel => Animals.Where(a => a.AnimalType == AnimalType.Carnivore).Select(a => (int)a.AnimalSize).FirstOrDefault();

        public Wagon()
        {
            animals = new List<Animal>();
        }

        public bool CheckAnimalAndAddToWagon(Animal animal)
        {
            if (SpacesLeft >= (int)animal.AnimalSize)
            {
                if (ThreatLevel!= 0)
                {
                    if ((int)animal.AnimalSize > ThreatLevel)
                    {
                        animals.Add(animal);
                        return true;
                    }
                }
                else
                {
                    animals.Add(animal);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string text = $"Space left {SpacesLeft} \r\n";
            int count = 0;
            foreach (var animal in animals)
            {
                count++;
                text += animal.ToString() + "\r\n";
            }
            return text;
        }
    }
}
