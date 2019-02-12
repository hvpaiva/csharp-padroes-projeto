using FactoryMethod.Pizza.Ingredients.Interfaces;

namespace FactoryMethod.Pizza.Ingredients
{
    public class ThinCrust : IDough
    {
        public string Name => "Thin Crust";
    }
}