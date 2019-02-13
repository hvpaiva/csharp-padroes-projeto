namespace Decorator
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 5.50;
        }
    }
}