using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.ConcreteImplementation
{
    public class NaxuxPayment : IPaymentSyatem
    {

        public void ProcessPayment()
        {
            Console.WriteLine("using nexus bank paymnet");
        }
    }
}
