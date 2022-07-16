using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Fruit : Product
    {
        private int count;
        public int Count { get => count; set => count = value; }

        public Fruit(string name, int count) : base(name)
        {
            Count = count;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({Count} fruits)");
        }
    }
}
