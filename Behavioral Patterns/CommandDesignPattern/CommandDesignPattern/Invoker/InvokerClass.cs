using System.Collections.Generic;
using CommandDesignPattern.Command;

namespace CommandDesignPattern.Invoker
{
    public class InvokerClass
    {
        public int ExecuteCommand(List<ICommand>list,string actionName)
        {
           // return command.Execute();

            foreach (var r in list)
            {
                if (r.Name.Equals(actionName))
                {
                    return r.Execute();
                }
            }

            return 0;
        }
    }
}