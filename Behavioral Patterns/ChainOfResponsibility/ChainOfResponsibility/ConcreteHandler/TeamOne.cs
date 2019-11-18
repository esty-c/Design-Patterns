using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class TeamOne : Handlerbase
    {
        public TeamOne(Handlerbase NextTeam, ContextObject Question)
            : base(NextTeam, Question)
        {
        
        }

        public override void HandleRequest()
        {
            Console.WriteLine("Waiting for answer Team1");
            Console.WriteLine("Team1 not found");
            NextTeam.HandleRequest();

        }
    }
}
