using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Command;
using CommandDesignPattern.Receiver;

namespace CommandDesignPattern.ConcreteCommand
{
    public class AddCommand : ICommand
    {

        Calculator calculator;


        public AddCommand(Calculator calculator)
        {
         
            this.calculator = calculator;
        }
        public int Execute()
        {
            return this.calculator.Add();
        }

        public string Name
        {
            get
            {
                return "Add";
            }
            
        }
    }
}
