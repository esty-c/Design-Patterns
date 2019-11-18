using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Command;
using CommandDesignPattern.Receiver;

namespace CommandDesignPattern.ConcreteCommand
{
    public class SubCommand : ICommand
    {
        Calculator calculator;
        public SubCommand(Calculator calculator)
        {
            this.calculator = calculator;
        }
        public int Execute()
        {
            return this.calculator.Sub();
        }

        public string Name
        {
            get
            {
                return "Sub";
            }

        }
    }
}
