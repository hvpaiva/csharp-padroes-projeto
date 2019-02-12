using System;

namespace Template.Beverage
{
    public abstract class Beverage
    {
        protected int _sugar;
        
        public bool WantsCondiments { get; set; }
        public int AddSugar { get; set; }

        public void Prepare()
        {
            Boil();
            Brew();
            Poul();
            if (WantsCondiments)
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();

        private void Boil()
        {
            Console.WriteLine("Fervendo água.");
        }

        private void Poul()
        {
            Console.WriteLine("Colocando no copo.");
        }

        protected abstract void AddCondiments();
        
        protected void Sugar() {}
    }
}