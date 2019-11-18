using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
  public  class TeamThree: Handlerbase
    {

      public TeamThree(Handlerbase NextTeam, ContextObject Question)
          : base(NextTeam, Question)
      { 
      
      }



      public override void HandleRequest()
      {
          Console.WriteLine("Team three solving problem");

          if (NextTeam == null)
          {
              Console.WriteLine("Solution not found");
          }

      }
    }
}
