using System;

namespace Strategy.Behaviour
{
    public class JumpNormal : IJumpBehaviour
    {
        public void Jump()
        {
            Console.WriteLine("Pulou 1m.");
        }
    }
}