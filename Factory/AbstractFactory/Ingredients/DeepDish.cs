using FactoryMethod.Pizza.Ingredients.Interfaces;

namespace FactoryMethod.Pizza.Ingredients
{
    public class DeepDish : IDough
    {
        public string Name => "Deep Dish";
    }
}