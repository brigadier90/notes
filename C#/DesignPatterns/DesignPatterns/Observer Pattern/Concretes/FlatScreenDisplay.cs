using System;
using DesignPatterns.ObserverPattern.Interfaces; 

namespace DesignPatterns.ObserverPattern.Concretes
{
    public class FlatScreenDisplay : IObserver
    {
        WeatherStation weatherStation;
        public FlatScreenDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void update()
        {
            showTemp();
        }

        public void showTemp()
        {
            Console.WriteLine("Current Temp: {0} C", weatherStation.temperature);
        }
    }
}
