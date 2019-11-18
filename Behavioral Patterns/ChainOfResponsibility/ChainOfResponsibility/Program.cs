using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
              ContextObject question = new ContextObject() { Question = "Who is an ediat in your team?" };
  
      var request=  new TeamOne(new TeamTwo(new TeamThree(null, question), question), question);
      request.HandleRequest();
        Console.ReadLine();
        }
    }
}
