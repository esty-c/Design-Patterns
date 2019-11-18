using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class HyperLink : Element
    {
        public string URL { get; set; }
        public HyperLink(string text, string url)
            : base(text)
        {
            this.URL = url;
        }


    }
}
