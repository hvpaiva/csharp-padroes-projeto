using System;

namespace Command
{
    internal class Garage
    {
        private readonly string _name;

        public Garage(string name)
        {
            _name = name;
        }

        internal void Close()
        {
            Console.WriteLine($"{_name} Garagem fechada.");
        }

        internal void Open()
        {
            Console.WriteLine($"{_name} Garagem aberta.");
        }
    }
}