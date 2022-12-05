using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            _name = "Chicago Style Deep Pan Pizza";
            _dough = "Thick Crust";
            _sauce = "Plum Tomato  Sauce";

            _toppings.Add("Shredded Mozarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into squares");
        }

    }
}
