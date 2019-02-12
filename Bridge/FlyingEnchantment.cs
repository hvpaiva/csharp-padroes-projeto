using System;

namespace Bridge
{
    public class FlyingEnchantment : IEnchantment
    {
        public void OnActivate(string weaponName)
        {
            Console.WriteLine($"{weaponName} começou a brilhar fracamente.");
        }

        public void Apply(string weaponName)
        {
            Console.WriteLine($"{weaponName} voou, atingiu o alvo e voltou a mão do dono!");
        }

        public void OnDeactivate(string weaponName)
        {
            Console.WriteLine($"{weaponName} voltou ao normal.");
        }
    }
}