using System.Collections.Generic;
using FactoryMethod.Pizza.Ingredients;
using FactoryMethod.Pizza.Ingredients.Interfaces;

namespace FactoryMethod.Pizza
{
    internal class ItallianIngredientsFactory : IIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new DeepDish();
        }

        public IEnumerable<IVeggies> CreateVeggies()
        {
            IVeggies[] veggies = {new Onion(), new Cucumber(), new CherryTomato()};
            return veggies;
        }

        public ISauce CreateSauce()
        {
            return new PlunTomato();
        }

        public ICheese CreateCheese()
        {
            return new Mozarella();
        }

        public IClam CreateClam()
        {
            return new FreshClam();
        }
    }
}