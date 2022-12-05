using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class NYStylePizzaStore : PizzaStore
    {
        Pizza myPizza = null;

        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType.Equals("cheese"))
            {
                myPizza = new NYStyleCheesePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                myPizza = new NYStylePepperoniPizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                myPizza = new NYStyleClamPizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                myPizza = new NYStyleVeggiePizza();
            }

            return myPizza;
        }
    }
}
