using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder builder { set { _builder = value; } }

       

        public void BuildSmallDish(string a, string b)
        {
            this._builder.AddIngredientA(a);
            this._builder.AddIngredientB(b);
        }
        public void BuildBigDish(string a, string b, string c)
        {
            this._builder.AddIngredientA(a);
            this._builder.AddIngredientB(b);
            this._builder.AddIngredientC(c);
            
        }
    }
}
