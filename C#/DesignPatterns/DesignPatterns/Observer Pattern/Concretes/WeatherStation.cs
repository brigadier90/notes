using System;
using System.Collections.Generic;
using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Concretes
{
    public class WeatherStation : IObservable
    {

        private List<IObserver> observers;
        public float temperature { get; private set; }

        public WeatherStation(float temperature)
        {
            this.observers = new List<IObserver>();
            this.temperature = temperature;
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }



        public void notify()
        {
            foreach(IObserver o in observers)
            {
                o.update();
            }
        }

        public void setTemperature(float temperature)
        {
            this.temperature = temperature;
            notify();
        }

        public void remove(IObserver observer)
        {
            try
            {
                observers.Remove(observer);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Item not found in list");
            }

        }
    }
}
