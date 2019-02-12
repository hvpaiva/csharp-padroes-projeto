using FactoryMethod.Pizza;

namespace Factory.FactoryMethod
{
    class NYPizzaFactory : PizzaFactory
    {
        protected override Pizza Create(PizzaType type)
        {
            Pizza pizza;
            IIngredientsFactory ingredients = new ItallianIngredientsFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredients) {Name = "Pizza de quijo de NY"};
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredients) {Name = "Pizza vegetariana de NY"};
                    break;
                default:
                    pizza = new ClamPizza(ingredients) {Name = "Pizza de frutos do mar de NY"};
                    break;
            }

            pizza.Color = "azul";

            return pizza;
        }
    }
}