using System;
using Decorator.Condiment;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Log(espresso);
            
            Beverage darkRoast = new DarkRoast();
            darkRoast = new MochaCondiment(darkRoast);
            darkRoast = new MochaCondiment(darkRoast);
            Log(darkRoast);
            
            Beverage house = new HouseBlend();
            house = new WhipCondiment(house);
            house = new MochaCondiment(house);
            Log(house);
        }

        private static void Log(Beverage beverage)
        {
            Console.WriteLine($"{beverage.Description}: R${beverage.Cost()}");
            Console.WriteLine();
        }
    }
}