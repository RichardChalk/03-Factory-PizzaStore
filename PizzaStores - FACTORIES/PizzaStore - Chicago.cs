using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        Pizza myPizza = null;

        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType.Equals("cheese"))
            {
                myPizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                myPizza = new ChicagoStylePepperoniPizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                myPizza = new ChicagoStyleClamPizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                myPizza = new ChicagoStyleVeggiePizza();
            }

            return myPizza;
        }
    }
}
