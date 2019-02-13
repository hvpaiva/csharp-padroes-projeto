namespace Decorator.Condiment
{
    internal class MochaCondiment : CondimentDecorator
    {
        private Beverage _beverage;

        public MochaCondiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description
        {
            get
            {
                if (_beverage.Description.StartsWith("Mocha"))
                {
                    return "Double " + _beverage.Description;
                }
                if (!_beverage.Description.StartsWith("Double Mocha"))
                {
                    return "Mocha " + _beverage.Description;   
                }

                return _beverage.Description;
            }
        }

        public override double Cost()
        {
            return 1.5 + _beverage.Cost();
        }
    }
}