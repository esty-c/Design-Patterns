using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class CityPaymentSystem :IPaymentSyatem
    {
        public void ProcessPayment()
        {
            Console.WriteLine("using city bank paymnet");
        }
    }
}
