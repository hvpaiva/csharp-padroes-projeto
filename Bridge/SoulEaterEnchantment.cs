using System;

namespace Bridge
{
    public class SoulEaterEnchantment : IEnchantment
    {
        public void OnActivate(string weaponName)
        {
            Console.WriteLine($"{weaponName} começou a brilhar cor de sangue!");
        }

        public void Apply(string weaponName)
        {
            Console.WriteLine($"{weaponName} sugou a alma do alvo!");
        }

        public void OnDeactivate(string weaponName)
        {
            Console.WriteLine($"{weaponName} voltou ao normal.");
        }
    }
}