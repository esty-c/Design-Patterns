namespace VisitorDesignPattern
{
    public abstract class Visitor
    {
        public string Content { get; set; }
        public void Visit(IElement element)
        {
            this.Content += element.Text;
        
        }
        public override string ToString()
        {
            return Content.ToString();
        }
    }
}