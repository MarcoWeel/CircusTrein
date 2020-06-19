using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Animal
    {
        public AnimalSize AnimalSize { get; private set; }
        public AnimalType AnimalType { get; private set; }

        public Animal(AnimalSize animalSize, AnimalType animalType)
        {
            AnimalSize = animalSize;
            AnimalType = animalType;
        }

        public override string ToString()
        {
            return AnimalSize + " " + AnimalType;
        }
    }
}
