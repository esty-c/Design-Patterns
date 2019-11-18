using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.ConcreteState
{
  public  class DeadState:IState
    {
        public void ExecuteState(Player player)
        {
            Console.WriteLine("Dead state");
        }
    }
}
