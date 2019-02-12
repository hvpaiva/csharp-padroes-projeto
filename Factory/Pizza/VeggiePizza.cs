using System;
using System.Linq;

namespace FactoryMethod.Pizza
{
    class VeggiePizza : Pizza
    {
        readonly IIngredientsFactory _ingredients;

        public VeggiePizza(IIngredientsFactory ing)
        {
            _ingredients = ing;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Preparando {Name} usando os seguintes ingredientes: ");
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