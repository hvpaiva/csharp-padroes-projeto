using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon sword = new Sword(new FlyingEnchantment());
            sword.Wield();
            sword.Swing();
            sword.Unwield();
            
            Console.WriteLine();
            
            IWeapon hammer = new Hammer(new SoulEaterEnchantment());
            hammer.Wield();
            hammer.Swing();
            hammer.Unwield();
        }
    }
}