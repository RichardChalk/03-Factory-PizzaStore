using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    abstract class Pizza
    {
        public string _name;
        public string _dough;
        public string _sauce;
        public List<string> _toppings = new List<string>();
        public void Prepare()
        {
            Console.WriteLine("Preparing a " + _name);
            
            for (int i = 0; i < _toppings.Count; i++)
            {
                Console.WriteLine("Toppings are " + _toppings[i]);
            }
        }
        public void Bake()
        {
            Console.WriteLine("Baking with " + _dough + " dough");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza diagonally");
        }

        public void Box()
        {
            Console.WriteLine("Boxing our " + _name);
        }

        public string GetName()
        {
            return _name;
        }


    }
}
