using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePeperoni();
        public Clams CreateClam();

    }
}
