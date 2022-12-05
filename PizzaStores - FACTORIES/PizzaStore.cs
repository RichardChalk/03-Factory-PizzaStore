using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza myPizza =null;

            myPizza = CreatePizza(pizzaType);

            myPizza.Prepare();
            myPizza.Bake();
            myPizza.Cut();
            myPizza.Box();

            return myPizza;
        }

        public abstract Pizza CreatePizza(string pizzaType);
    }
}
