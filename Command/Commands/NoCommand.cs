using System;

namespace Command
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Sem comando atribuído.");
        }

        public void Undo()
        {
            Execute();
        }
    }
}