using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var mage = new Mage();
            mage.Perform();
            
            var warrior = new Warrior();
            warrior.Perform();
        }
    }
}