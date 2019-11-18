using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmployee worker1 = new Worker("Alkesh", "Kanshat");

            IEmployee worker2 = new Worker("Serajul", "Kanshat");
            IEmployee worker3 = new Worker("Mophu", "Ajgobi");


            Supervisor safu = new Supervisor("Safu", "Guripara");

            safu.AddEmployee(worker1);
            safu.AddEmployee(worker2);
            safu.AddEmployee(worker3);
            Supervisor esty = new Supervisor("Esty", "Captan bari");
            esty.AddEmployee(safu);


            safu.GetEmployee(1);

            Console.ReadLine();


        }
    }
}
