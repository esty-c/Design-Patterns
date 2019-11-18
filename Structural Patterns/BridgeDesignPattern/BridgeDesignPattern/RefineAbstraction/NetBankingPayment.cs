using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
 public   class NetBankingPayment :Paymnet
    {

        public override void MakePayment(string param)
        {
            Console.WriteLine("Net banking payment");
        }
    }
}
