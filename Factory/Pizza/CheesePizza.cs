using System;
using System.Linq;

namespace FactoryMethod.Pizza
{
    class CheesePizza : Pizza
    {
        private readonly IIngredientsFactory _ingredients;


        public CheesePizza(IIngredientsFactory ingredients)
        {
            _ingredients = ingredients;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Praparando {Name} usando os seguintes ingredientes: ");

            Console.Write(
                $"Massa: {_ingredients.CreateDough().Name}, " +
                $"queijo: {_ingredients.CreateCheese().Name}, " +
                $"molho: {_ingredients.CreateSauce().Name}, vegetais: "
            );
            
            Console.Write(string.Join(", ", _ingredients.CreateVeggies().Select(veggies => veggies.Name)));
            
            Console.WriteLine();
        }
    }
}