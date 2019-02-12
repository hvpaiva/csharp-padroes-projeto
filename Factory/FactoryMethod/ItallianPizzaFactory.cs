using FactoryMethod.Pizza;

namespace Factory.FactoryMethod
{
    class ItallianPizzaFactory : PizzaFactory
    {
        protected override Pizza Create(PizzaType type)
        {
            Pizza pizza;
            IIngredientsFactory ingredients = new ItallianIngredientsFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredients) {Name = "Pizza de quijo italiana"};
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredients) {Name = "Pizza vegetariana italiana"};
                    break;
                default:
                    pizza = new ClamPizza(ingredients) {Name = "Pizza de frutos do mar italiana"};
                    break;
            }

            pizza.Color = "vermelho";

            return pizza;
        }
    }
}