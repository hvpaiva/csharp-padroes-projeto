using System;

namespace Strategy.Behaviour
{
    public class FlyNope : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Não pode voar.");
        }
    }
}