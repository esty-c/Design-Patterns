namespace VisitorDesignPattern
{
    public class Element : IElement
    {
        public string Text { get; set; }

        public Element(string Text)
        {
            this.Text = Text;
        }

        public void Accept(Visitor visitor)
        {


            dynamic visitable = this;
            dynamic newVisitor = visitor;
            newVisitor.Visit(visitable);
        }
    }
}