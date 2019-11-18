using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.ConcreteState
{
  public  class HealthyState:IState
    {


        public void ExecuteState(Player player)
        {
            Console.WriteLine("Player is healthy");
        }
    }
}
