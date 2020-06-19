using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustrein
{
    public partial class Form1 : Form
    {
        Train train = new Train();
        List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            CBSize.DataSource = Enum.GetValues(typeof(AnimalSize));
            CBType.DataSource = Enum.GetValues(typeof(AnimalType));
        }

        private void BTNAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal((AnimalSize)CBSize.SelectedItem, (AnimalType)CBType.SelectedItem);
            LBAnimals.Items.Add(animal);
            animals.Add(animal);
        }

        private void BTNSort_Click(object sender, EventArgs e)
        {
            train.ClearWagonList();
            WagonTextBox.Clear();
            List<Wagon> wagons = new List<Wagon>();
            wagons = Sorter.AnimalsToWagons(animals);
            train.AddWagons(wagons);
            var listviewitem = new ListViewItem(train.ToString());
            WagonTextBox.Text = train.ToString();
            animals.Clear();
            LBAnimals.Items.Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            WagonTextBox.Clear();
            LBAnimals.Items.Clear();
            animals.Clear();
            train.ClearWagonList();
        }
    }
}

