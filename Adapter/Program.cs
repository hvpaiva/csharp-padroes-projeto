using System;
using Adapter.Birds;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);
            
            Log(adapter);
        }

        private static void Log(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}