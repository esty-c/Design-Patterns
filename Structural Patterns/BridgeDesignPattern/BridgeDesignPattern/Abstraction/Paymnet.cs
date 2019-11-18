using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
  public abstract  class Paymnet
    {
      public IPaymentSyatem _IPaymentSystem;
      public abstract void MakePayment(string str);
    }
}
