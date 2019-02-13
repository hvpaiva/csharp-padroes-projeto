namespace Decorator.Condiment
{
    internal class WhipCondiment : CondimentDecorator
    {
        private Beverage _beverage;

        public WhipCondiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description
        {
            get
            {
                if (_beverage.Description.StartsWith("Whip"))
                {
                    return "Double " + _beverage.Description;
                }

                if (!_beverage.Description.StartsWith("Double Whip"))
                {
                    return "Whip " + _beverage.Description;
                }

                return _beverage.Description;
            }
        }

        public override double Cost()
        {
            return 0.5 + _beverage.Cost();
        }
    }
}