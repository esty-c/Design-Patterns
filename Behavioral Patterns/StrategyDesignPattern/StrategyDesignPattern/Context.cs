using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Context
    {

        List<String> list = new List<string>();
        SortStrategy strategy;
        public Context(SortStrategy strategy, List<String> list)
        {
            this.strategy = strategy;
            this.list = list;
        }


        public void Sort()
        {

            strategy.Sort(list);

            foreach (var r in list)
            {
                Console.WriteLine(r);
            }
        }
    }
}
