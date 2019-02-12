using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class WeatherMonitor : IObserver<Weather>
    {
        private IDisposable _cancellation;
        private readonly WeatherParamsType[] _show;

        public WeatherMonitor(params WeatherParamsType[] show)
        {
            _show = show;
        }

        public void Subscribe(WeatherSupplier supplier)
        {
            _cancellation = supplier.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Um erro ocorreu.");
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine(
                string.Join(
                    ", ",
                    _show.Select(show =>
                        Enum.GetName(typeof(WeatherParamsType), show))
                )
            );

            foreach (var show in _show)
            {
                switch (show)
                {
                    case WeatherParamsType.Temperature:
                        Console.WriteLine($"Temperatura: {value.Temperature} ºC");
                        break;
                    case WeatherParamsType.Pressure:
                        Console.WriteLine($"Pressão: {value.Pressure} atm");
                        break;
                    case WeatherParamsType.Humidity:
                        Console.WriteLine($"Humidade: {value.Humidity * 100}%");
                        break;
                    default:
                        OnError(new Exception());
                        break;
                }
            }

            Console.WriteLine();
        }
    }
}