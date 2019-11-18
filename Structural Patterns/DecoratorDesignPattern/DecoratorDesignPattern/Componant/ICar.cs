using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Componant
{
  public  interface ICar
    {
      String Make { get; }
      double GetPrice(); 
    }
}
