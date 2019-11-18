using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Componant;

namespace DecoratorDesignPattern.Decoder
{
    public abstract class CarDecorator : ICar
    {
        ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public string Make
        {
            get { return car.Make; }
        }

        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }
}
