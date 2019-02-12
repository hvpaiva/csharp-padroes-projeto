using System;

namespace FactoryMethod.Pizza
{
    internal abstract class Pizza
    {

        public string Color { get; set; }
        public string Name { get; set; }

        internal abstract void Prepare();


        internal void Bake()
        {
            Console.WriteLine("Assando a 140 graus celsius por 20 minutos.");
        }

        internal void Cut()
        {
            Console.WriteLine("Cortando em 8 peças diagonais.");
        }

        internal void Box()
        {
            Console.WriteLine($"Colocando a pizza na caixa {Color}.");
        }
    }
}