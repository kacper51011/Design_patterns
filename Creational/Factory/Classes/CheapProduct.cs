using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    internal class CheapProduct : IProduct
    {
        public void getDetails()
        {
            Console.WriteLine("Cheap but good product");
        }

        public void getPrice()
        {
            Console.WriteLine("Price: 15$");
        }
    }
}
