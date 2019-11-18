using DecoratorDesignPattern.Componant;
namespace DecoratorDesignPattern.ConcreteComponent
{
    public sealed class Hyundai : ICar
    {
        public string Make
        {
            get { return  "Hyundai"; }
        }

        public double GetPrice()
        {
            return 700000;
        }
    }
}