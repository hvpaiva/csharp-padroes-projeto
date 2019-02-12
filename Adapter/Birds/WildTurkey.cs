using System;

namespace Adapter.Birds
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble Gobble!");
        }

        public void Fly()
        {
            Console.WriteLine("Voou 100 metros.");
        }
    }
}