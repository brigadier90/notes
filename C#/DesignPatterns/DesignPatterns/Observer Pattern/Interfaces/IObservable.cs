using System;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface IObservable
    {

        void Add(IObserver observer);
        void remove(IObserver observer);
        void notify();


         

    }
}
