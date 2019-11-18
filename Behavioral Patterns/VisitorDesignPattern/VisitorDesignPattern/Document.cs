using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Document
    {

        public List<IElement> Elements = new List<IElement>();
        //public void Add(IElement element)
        //{
        //    Elements.Add(element);
        //}


        public void Accept(Visitor visitor)
        {

            foreach (var r in Elements)
            { 
              //visitor.

                r.Accept(visitor);
            }
        }

    }
}
