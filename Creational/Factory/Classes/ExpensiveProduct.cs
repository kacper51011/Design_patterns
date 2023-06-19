using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    public class ExpensiveProduct : IProduct
    {
        public void getDetails()
        {
            Console.WriteLine("High quality product");
        }

        public void getPrice()
        {
            Console.WriteLine("Price: 50$");
        }
    }
}
