namespace Decorator.Condiment
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}