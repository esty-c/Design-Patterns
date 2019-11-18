using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class HTMLString : Visitor
    {
        public void Visit(BoldText element)
        {
            this.Content += string.Format("<b>{0}</b>", element.Text);

        }
        public void Visit(HyperLink element)
        {
            this.Content += string.Format("<a href='{0}'>{1}</a>", element.URL, element.Text);

        }
        public void Visit(Paragraph element)
        {
            this.Content += string.Format("<p>{0}</p>", element.Text);

        }
        public override string ToString()
        {
            return Content.ToString();
        }

    }
}
