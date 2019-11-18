using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.ConcreteObserver;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern
{
  public  interface ISubject
    {

      //public List<Shop> list = new List<Shop>();
      //public List<IObserver> list = new List<IObserver>();
       void RegisterObserver(IObserver observer);


       void UnregisterObserver(IObserver observer);

        void NotifyObservers(string pushMessage);


    }
}
