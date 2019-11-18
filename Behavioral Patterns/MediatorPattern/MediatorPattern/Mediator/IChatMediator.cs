using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator
{
    public interface IChatMediator
    {
        void Register(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
