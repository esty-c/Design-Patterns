using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   public abstract class Handlerbase
    {

       public Handlerbase NextTeam { get; private set; }
       public ContextObject Question { get; private set; }

       public Handlerbase(Handlerbase NextTeam, ContextObject Question)
       {
           this.NextTeam = NextTeam;
           this.Question = Question;
       }



       public abstract void HandleRequest();


    }
}
