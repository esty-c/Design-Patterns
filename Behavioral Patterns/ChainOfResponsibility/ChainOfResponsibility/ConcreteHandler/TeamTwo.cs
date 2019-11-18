using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
  public  class TeamTwo :Handlerbase
    {
      public TeamTwo(Handlerbase NextTeam, ContextObject Question)
          : base(NextTeam, Question)
      { 
      
      }



      public override void HandleRequest()
      {
          Console.WriteLine("Team two solving request");
          Console.WriteLine("Team two Failed. Sending next");
          NextTeam.HandleRequest();


      }
    }
}
