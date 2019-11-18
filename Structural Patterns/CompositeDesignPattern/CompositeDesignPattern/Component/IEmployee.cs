using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public interface IEmployee
    {
         String Name { get; }
         String Address { get; }
         void GetEmployee(int indentation);
    }
}
