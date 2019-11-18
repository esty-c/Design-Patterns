using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> list = new List<string>();
            list.Add("V");
            list.Add("A");
            list.Add("C");
            var context = new Context(new QuickSort(), list);
            context.Sort();
            Console.ReadLine();
        }
    }
}
