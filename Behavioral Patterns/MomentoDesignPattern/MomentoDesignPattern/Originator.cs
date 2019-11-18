namespace MomentoDesignPattern
{
    public class Originator<T>
    {
        public T State { get; set; }

        public Memento<T> CreateMomento()
        {
            Memento<T> obj = new Memento<T>();
            obj.State = State;
            return obj;
        }

        //public void SetMomento(Memento<T> m)
        //{
        //    State = m.State;
        //}
    }
}