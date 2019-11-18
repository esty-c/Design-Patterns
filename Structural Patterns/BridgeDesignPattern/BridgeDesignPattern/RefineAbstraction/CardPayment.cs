using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
  public  class CardPayment :Paymnet
    {




        public override void MakePayment(string str)
        {

            _IPaymentSystem.ProcessPayment();
            Console.WriteLine("Card Payment...."); ;
        }
    }
}
