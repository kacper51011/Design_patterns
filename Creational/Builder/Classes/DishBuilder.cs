using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class DishBuilder : IBuilder
    {
        // stored instance of a dish, new instance appear after invoking builder instance or serving dish
        private Dish _dish = new Dish();
        public DishBuilder()
        {
            this.Reset();
        }

        // Reset method, needed because we need a method which create new dish instance after serving
        public void Reset()
        {
            this._dish = new Dish();
        }


        // methods coming from Builder interface
        public void AddIngredientA(string a)
        {
            _dish.Add(a);
        }

        public void AddIngredientB(string b)
        {
            _dish.Add(b);
        }

        public void AddIngredientC(string c)
        {
            _dish.Add(c);
        }

        public void ServeDish()
        {
            Console.WriteLine("Serving dish with ingredients:");
            this._dish.ShowIngredients();

            this.Reset();
        }
    }
}
