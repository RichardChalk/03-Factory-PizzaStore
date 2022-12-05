using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            _name = "New York Style Pizza";
            _dough = "Thin Crust";
            _sauce = "Marinara Sauce";

            _toppings.Add("Veggies");
        }
    }
}
