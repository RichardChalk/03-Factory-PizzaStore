using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -

            // 1. Följ exemplet och skriv koden i denna fil "Factory Design Pattern.pdf"
            // 2. Rita ditt eget UML diagram i Draw.io som beskriver din kod

            // OBS: Exemplet i pdf filen är skriven i Java... du ska så klart skriva i C#!
            // ///////////////////////////////////////////////////////////////////////////

            // A NY cheese pizza
            PizzaStore myNYPizzaStore = new NYStylePizzaStore();
            Pizza myPizza = myNYPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Linda ordered a: " + myPizza.GetName());

            Console.WriteLine();

            // A chicago pepperoni
            PizzaStore myChicagoPizzaStore = new ChicagoStylePizzaStore();
            Pizza myChicPizza = myChicagoPizzaStore.OrderPizza("pepperoni");
            Console.WriteLine("Richard ordered a: " + myChicPizza.GetName());
        }
    }
}
