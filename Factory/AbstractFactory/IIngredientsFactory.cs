using System.Collections.Generic;
using FactoryMethod.Pizza.Ingredients.Interfaces;

namespace FactoryMethod.Pizza
{
    public interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}