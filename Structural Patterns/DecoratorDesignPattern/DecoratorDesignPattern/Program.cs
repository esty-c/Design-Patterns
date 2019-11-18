using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.ConcreteComponent;
using DecoratorDesignPattern.ConcreteDecoder;
using DecoratorDesignPattern.Decoder;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var car = new OfferPrice20PrecentDiscount(new Hyundai());
            Console.WriteLine("Car Name: " + car.Make );
            Console.WriteLine("Original Price: " + car.GetPrice());
            Console.WriteLine("Discounted Price: "+  car.GetDiscountedPrice());
            Console.ReadLine();
        }
    }
}
