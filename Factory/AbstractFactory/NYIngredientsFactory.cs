using System.Collections.Generic;
using FactoryMethod.Pizza.Ingredients;
using FactoryMethod.Pizza.Ingredients.Interfaces;

namespace FactoryMethod.Pizza
{
    internal class NYIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Mozarella();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FrozenClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new ThinCrust();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new PlunTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            IVeggies[] veggies = {new Onion(), new Cucumber(), new Olive()};
            return veggies;
        }
    }
}