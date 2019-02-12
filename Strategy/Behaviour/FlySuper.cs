using System;

namespace Strategy.Behaviour
{
    public class FlySuper : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Começou a voar.");
        }
    }
}