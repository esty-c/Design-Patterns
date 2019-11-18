using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
  public  class BoldText :Element
    {
      public BoldText(string text)
          : base(text)
      { }

    }
}
