using System;

namespace Template.Beverage
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Adicionando as ervas do chá à água e colocando para ferver.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adicionando Limão e Açúcar.");
        }

        private new void Sugar()
        {
            Console.WriteLine($"Adicionando {_sugar} cubos de açúcar.");
            Sugar();
        }

        public new int AddSugar
        {
            set => _sugar = value;
        }
    }
}