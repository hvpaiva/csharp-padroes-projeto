using System;

namespace Bridge
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;
        private static string Name { get; set; }

        public Sword(IEnchantment enchantment)
        {
            _enchantment = enchantment;
            Name = "A espada";
        }

        public void Wield()
        {
            Console.WriteLine($"{Name} foi manejada!");
            _enchantment.OnActivate(Name);
        }

        public void Swing()
        {
            Console.WriteLine($"{Name} foi balançada!");
            _enchantment.Apply(Name);
        }

        public void Unwield()
        {
            Console.WriteLine($"{Name} foi empunhada!");
            _enchantment.OnDeactivate(Name);
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
        
    }
}