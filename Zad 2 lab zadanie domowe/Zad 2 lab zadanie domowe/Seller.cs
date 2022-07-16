using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {

        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix} Seller: {Name} ({Age} y.o.)");
        }
    }
}
