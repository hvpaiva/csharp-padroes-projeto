using System;

namespace Singleton
{
    internal partial class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> _singleton =
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public static ChocolateBoiler GetInstance() => _singleton.Value;

        private Status _boiler;

        private ChocolateBoiler()
        {
            Console.WriteLine("Iniciando...");
            _boiler = Status.Empty;
        }

        public void Fill()
        {
            if (!IsEmpty) return;
            
            Console.WriteLine("Enchendo...");
            _boiler = Status.InProgress;
        }

        public void Drain()
        {
            if (IsEmpty) return;
            
            Console.WriteLine("Esvaziando...");
            _boiler = Status.Empty;
        }

        public void Boil()
        {
            if (IsBoiled) return;
            
            Console.WriteLine("Fervendo...");
            _boiler = Status.Boiled;
        }
        
        private bool IsEmpty => (_boiler == Status.Empty);

        private bool IsBoiled => (_boiler == Status.Boiled);
    }
}