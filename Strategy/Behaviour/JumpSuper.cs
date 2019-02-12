using System;

namespace Strategy.Behaviour
{
    public class JumpSuper : IJumpBehaviour
    {
        public void Jump()
        {
            Console.WriteLine("Pulou 100m.");
        }
    }
}