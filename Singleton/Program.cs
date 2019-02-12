using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var choco = ChocolateBoiler.GetInstance();
            choco.Fill();
            choco.Boil();
            choco.Drain();
        }
    }
}