using System;

namespace Strategy.Behaviour
{
    public class JumpNope : IJumpBehaviour
    {
        public void Jump()
        {
            Console.WriteLine("Não pode pular.");
        }
    }
}