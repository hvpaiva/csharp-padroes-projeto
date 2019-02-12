using System;

namespace Facade
{
    public class Dimmer
    {
        internal void Dim(int value) => 
            Console.WriteLine(value == 10 ? "Ativando a luz" : $"Mudando a luz para {value}");

        internal void Off() => Console.WriteLine("Desligando as luzes");

    }
}