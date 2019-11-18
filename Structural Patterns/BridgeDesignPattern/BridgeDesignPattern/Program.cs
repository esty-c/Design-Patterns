using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.ConcreteImplementation;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Paymnet order = new CardPayment();
            order._IPaymentSystem = new NaxuxPayment();
            order.MakePayment("ciry paymnet");
            Console.ReadLine();
        }
    }
}
