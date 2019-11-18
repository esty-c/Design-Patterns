using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Componant;
using DecoratorDesignPattern.Decoder;

namespace DecoratorDesignPattern.ConcreteDecoder
{
  public  class OfferPrice20PrecentDiscount : CarDecorator
    {
      public OfferPrice20PrecentDiscount(ICar car)
          : base(car)
      { 
      
      }
        public override double GetDiscountedPrice()
        {
            return 0.8 * base.GetPrice();
        }
    }
}
