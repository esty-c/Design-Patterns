using System.Collections.Generic;

namespace ObserverDesignPattern.ConcreteSubject
{
    public class PushNotification : ISubject
    {
        private List<Observer.IObserver> list = new List<Observer.IObserver>();

        public void Push(string message)
        {
            NotifyObservers(message);
        }

        public void RegisterObserver(Observer.IObserver observer)
        {
            list.Add(observer);
        }

        public void UnregisterObserver(Observer.IObserver observer)
        {
            list.Remove(observer);
        }

        public void NotifyObservers(string pushMessage)
        {
            foreach (var r in list)
            {
                r.Update(pushMessage);
            }
        }
    }
}