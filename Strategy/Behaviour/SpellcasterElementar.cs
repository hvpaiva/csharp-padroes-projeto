using System;

namespace Strategy.Behaviour
{
    public class SpellcasterElementar : ISpellcasterBehaviour
    {
        public void Cast()
        {
            Console.WriteLine("Invocou uma chuva de fogo.");
        }
    }
}