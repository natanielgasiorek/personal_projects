using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Product : IThing
    {
        private string name;
        public string Name { get => this.name; set => this.name = value; }

        public Product(string name)
        {
            Name = name;
        }
         public virtual void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name}");  // tego nie rozumiem
        }
    }
}
