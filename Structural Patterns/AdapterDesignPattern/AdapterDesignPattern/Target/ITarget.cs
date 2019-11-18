using System.Collections.Generic;

namespace AdapterDesignPattern
{
    public interface ITarget
    {
        List<string> GetBooks();
    }
}