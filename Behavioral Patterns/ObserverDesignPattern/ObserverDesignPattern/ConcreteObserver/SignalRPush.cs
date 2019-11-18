using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern.ConcreteObserver
{
  public  class SignalRPush :IObserver
    {
         string name = "SignalR push";
         public void Update(string pushMessage)
         {
             Console.WriteLine(this.name + " sent " + pushMessage);
         }
    }
}
