using System;

namespace Template.Beverage
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Adicionando os grãos de café à água e colocando para ferver.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adicionando Leite.");
        }
    }
}