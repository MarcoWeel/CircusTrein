using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustrein
{
    public class Train
    {
        private List<Wagon> wagons;
        public IReadOnlyCollection<Wagon> Wagons
        {
            get { return wagons.AsReadOnly(); }
        }

        public Train()
        {
            wagons = new List<Wagon>();
        }

        public void AddWagons(List<Wagon> wagonsList)
        {
            foreach (var wagon in wagonsList)
            {
                wagons.Add(wagon);
            }
        }

        public void ClearWagonList()
        {
            wagons.Clear();
        }

       public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            foreach (var wagon in wagons)
            {
                foreach (var animal in wagon.Animals)
                {
                    animals.Add(animal);
                }
            }

            return animals;
        } 

        public override string ToString()
        {
            string text = null;
            int count = 0;
            foreach (var wagon in wagons)
            {
                count++;
                text += "Wagon: " + count + " " +  wagon.ToString() + "\r\n";
            }
            return text;
            //return string.Format("Wagon:{0}", count);
        }
    }

}
