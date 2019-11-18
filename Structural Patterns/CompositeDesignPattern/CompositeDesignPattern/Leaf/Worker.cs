using System;

namespace CompositeDesignPattern
{
    public class Worker : IEmployee
    {


        public  Worker(String Name, String Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public string Name{ get; set; }

        public string Address { get; set; }


        public void GetEmployee(int indentation)
        {
            Console.WriteLine(new String('-',indentation)+"Name: " + Name + "   Address: " + this.Address+"   Leaf");
        }
    }
}