using System;

namespace Strategy.Behaviour
{
    public class SpellcasterArcane : ISpellcasterBehaviour
    {
        public void Cast()
        {
            Console.WriteLine("Invocou uma onda arcana.");
        }
    }
}