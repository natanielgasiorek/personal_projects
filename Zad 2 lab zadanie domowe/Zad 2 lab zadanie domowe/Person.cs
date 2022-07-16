using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Person : IThing
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({Age} y.o.)");
        }
    }
}
