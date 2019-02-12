using System;
using System.Linq;

namespace FactoryMethod.Pizza
{
    class ClamPizza : Pizza
    {
        private readonly IIngredientsFactory _ingredients;

        public ClamPizza(IIngredientsFactory ingredients)
        {
            _ingredients = ingredients;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Preparando {Name} usando os seguintes ingredientes: ");
            Console.Write(
                $"Massa: {_ingredients.CreateDough().Name}, " +
                $"molusco: {_ingredients.CreateClam().Name}, " +
                $"molho: {_ingredients.CreateSauce().Name}, vegetais: "
            );

            Console.Write(string.Join(", ", _ingredients.CreateVeggies().Select(veggies => veggies.Name)));
            
            Console.WriteLine();
        }
    }
}