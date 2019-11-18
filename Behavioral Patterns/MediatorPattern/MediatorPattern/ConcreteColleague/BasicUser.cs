﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Mediator;

namespace MediatorPattern.ConcreteColleague
{
    public class BasicUser : IUser
    {
        string name;
        IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }
        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Basic -- " + name + "; received message: " + message);
        }
    }
}
