using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Meat : Product
    {
        private double weight;
        public double Weight { get => weight; set => weight = value; }

        public Meat(string name, double weight) : base(name)
        {
            Weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({Weight} kg)");
        }
    }
}
