using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "New York Style Pizza";
            _dough = "Thin Crust";
            _sauce = "Marinara Sauce";

            _toppings.Add("Reggiano Cheese");
            _toppings.Add("Mushrooms");
        }
        
    }
}
