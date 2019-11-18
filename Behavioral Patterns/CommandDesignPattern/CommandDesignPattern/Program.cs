using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Command;
using CommandDesignPattern.ConcreteCommand;
using CommandDesignPattern.Invoker;
using CommandDesignPattern.Receiver;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcualtor = new Calculator(6,4);
           // ICommand add = ;
            ICommand sub = new SubCommand(calcualtor);
       

            List<ICommand> list = new List<ICommand>();
            list.Add(new AddCommand(calcualtor));
            list.Add(sub);
            Console.WriteLine("result: " +  new InvokerClass().ExecuteCommand(list,"Add"));

            Console.ReadLine();

        }
    }
}
