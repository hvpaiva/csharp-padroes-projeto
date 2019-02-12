using System;

namespace Bridge
{
    public class Hammer: IWeapon
    {
        private readonly IEnchantment _enchantment;
        private string Name { get; set; }

        public Hammer(IEnchantment enchantment)
        {
            _enchantment = enchantment;
            Name = "O martelo";
        }

        public void Wield()
        {
            Console.WriteLine($"{Name} foi manejado!");
            _enchantment.OnActivate(Name);
        }

        public void Swing()
        {
            Console.WriteLine($"{Name} foi balançado!");
            _enchantment.Apply(Name);
        }

        public void Unwield()
        {
            Console.WriteLine($"{Name} foi empunhado!");
            _enchantment.OnDeactivate(Name);
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}