using System;

namespace Command
{
    public class Light
    {
        private readonly string _name;

        public Light(string name)
        {
            _name = name;
        }

        internal void On()
        {
            Console.WriteLine($"{_name} luz acesa");
        }

        internal void Off()
        {
            Console.WriteLine($"{_name} luz apagada");
        }
    }
}