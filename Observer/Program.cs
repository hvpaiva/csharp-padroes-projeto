using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = new WeatherSupplier();
            var observer1 = new WeatherMonitor(
                WeatherParamsType.Temperature
            );
            var observer2 = new WeatherMonitor(
                WeatherParamsType.Temperature, WeatherParamsType.Humidity
            );
            var observer3 = new WeatherMonitor(
                WeatherParamsType.Temperature, WeatherParamsType.Humidity, WeatherParamsType.Pressure
            );
            
            // Nenhum observer
            supplier.WeatherConditions(32.0, 0.05, 1.5);
            
            // Um observer de temperatura
            observer1.Subscribe(supplier);
            supplier.WeatherConditions(33.5, 0.04, 1.7);
            
            // Todos observers
            observer2.Subscribe(supplier);
            observer3.Subscribe(supplier);
            supplier.WeatherConditions(37.5, 0.07, 1.2);
            supplier.WeatherConditions(39.2, 0.03, 1.8);
        }
    }
}