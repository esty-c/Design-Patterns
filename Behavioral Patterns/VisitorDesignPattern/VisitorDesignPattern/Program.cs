using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var doc = new Document();
            doc.Elements.Add(new BoldText("Header Text"));
            doc.Elements.Add(new Paragraph("test paragraph"));
            doc.Elements.Add(new HyperLink("test url","htttp://www.google.com"));

            var html = new HTMLString();
            doc.Accept(html);

            Console.WriteLine(html.ToString());
            Console.ReadLine();

        }
    }
}
