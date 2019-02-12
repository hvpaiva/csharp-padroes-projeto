using System;

namespace Adapter.Birds
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("Voou 500 metros.");
        }
    }
}