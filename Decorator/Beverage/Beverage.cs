namespace Decorator
{
    internal abstract class Beverage
    {
        protected string _description = "Sem descrição.";

        public abstract string Description { get; }
        public abstract double Cost();
    }
}