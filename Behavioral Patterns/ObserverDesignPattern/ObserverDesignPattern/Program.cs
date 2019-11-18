using System;
using ObserverDesignPattern.ConcreteObserver;
using ObserverDesignPattern.ConcreteSubject;

namespace ObserverDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PushNotification product = new PushNotification();

            product.RegisterObserver(new ApplePush());
            product.RegisterObserver(new FirebasePush());
            product.RegisterObserver(new SignalRPush());

            while (true)
            {
                Console.WriteLine("Please enter your message: ");
                string msg = Console.ReadLine();
                product.Push(msg);
            }


        }
    }
}