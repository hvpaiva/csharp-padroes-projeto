using System;

namespace Strategy.Behaviour
{
    public class SpellcasterNope : ISpellcasterBehaviour
    {
        public void Cast()
        {
            Console.WriteLine("Não pode castar spells.");
        }
    }
}