namespace CommandDesignPattern.Receiver
{
    public class Calculator
    {
        public int a;
        public int b;

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add()
        {
            return a + b;
        }

        public int Sub()
        {
            return a - b;
        }
    }
}