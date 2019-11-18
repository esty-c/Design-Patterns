using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.ConcreteColleague;
using MediatorPattern.Mediator;

namespace MediatorPattern
{
    //The Gang of Four likes to draw examples from GUIs, so naturally their examples revolve around windows, buttons, text panes, list boxes, etc. If each of these widgets communicated directly with each of the others, the result would be a spiderweb of communication. Restricting each widget to communicate only with a single mediator simplifies the communication pattern. Also see this answer for a similar explanation.
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser john = new BasicUser(chatMediator, "John");
            IUser tina = new PremiumUser(chatMediator, "Tina");
            IUser lara = new PremiumUser(chatMediator, "Lara");

            chatMediator.Register(john);
            chatMediator.Register(tina);
            chatMediator.Register(lara);

            tina.SendMessage("Hello Everyone!");
            Console.ReadLine();
        }


    }


}
