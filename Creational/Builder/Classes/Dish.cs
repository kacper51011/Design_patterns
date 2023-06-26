using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class Dish
    {
        private List<string> _ingredients = new List<string>();

        public void Add(string part)
        {
            this._ingredients.Add(part);
        }

        public void ShowIngredients()
        {
            string str = string.Empty;

           foreach(string s in this._ingredients)
            {
                str += s + " ";
            }


            Console.WriteLine(str);
        }
    }
}
