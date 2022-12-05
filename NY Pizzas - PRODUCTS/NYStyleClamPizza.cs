using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            _name = "New York Style Pizza";
            _dough = "Thin Crust";
            _sauce = "Marinara Sauce";

            _toppings.Add("Clams");
        }

    }
}
