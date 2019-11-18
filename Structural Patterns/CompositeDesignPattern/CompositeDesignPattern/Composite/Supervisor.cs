using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public class Supervisor : IEmployee
    {
        private List<IEmployee> subordinates = new List<IEmployee>();

        public Supervisor(string Name, String Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public void AddEmployee(IEmployee employee)
        {
            subordinates.Add(employee);
        }

        public void GetEmployee(int indentation)
        {
            Console.WriteLine(new String('-', indentation) + "Name: " + Name + "   Address: " + this.Address + "Composite");
            foreach (var r in subordinates)
            {
                r.GetEmployee(indentation + 1);
            }
        }
    }
}