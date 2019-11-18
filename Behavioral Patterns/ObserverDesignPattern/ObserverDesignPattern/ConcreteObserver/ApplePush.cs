using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.ConcreteSubject;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern.ConcreteObserver
{
  public  class ApplePush :IObserver
    {


      string name = "Apple push";





      public void Update(string pushMessage)
        {
            Console.WriteLine(this.name + " sent "+pushMessage);
        }
    }
}
