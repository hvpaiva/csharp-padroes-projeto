using System;
using Factory.FactoryMethod;
using FactoryMethod.Pizza;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var italianos = new ItallianPizzaFactory();
            Console.WriteLine("Entrando em restaurante italiano e pedindo uma pizza!");
            italianos.Order(PizzaType.Cheese);
            Console.WriteLine();
            
            var yankees = new NYPizzaFactory();
            Console.WriteLine("Entrando em restaurante americano e pedindo uma pizza!");
            yankees.Order(PizzaType.Veggie);
            Console.WriteLine();
            
        }
    }
}