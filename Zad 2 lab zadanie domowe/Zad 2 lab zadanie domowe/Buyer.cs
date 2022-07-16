using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_lab_zadanie_domowe
{
    internal class Buyer : Person
    {
        protected List<Product> products = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {

        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            products.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix} Buyer: {Name} ({Age} y.o.)");

            if (products.Count > 0)
            {
                Console.WriteLine($"{prefix}\t-- Products: --");
                foreach (var item in products)
                {
                    item.Print($"{prefix}\t");
                }
            }
        }
    }
}
