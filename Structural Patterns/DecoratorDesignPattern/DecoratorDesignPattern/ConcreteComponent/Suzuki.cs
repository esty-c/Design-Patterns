using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Componant;

namespace DecoratorDesignPattern.ConcreteComponent
{
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get {return "Suzuki"; }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }
}
