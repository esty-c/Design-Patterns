using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
           // list.ShellSort();
            Console.WriteLine("ShellSort");
        }
    }
}
