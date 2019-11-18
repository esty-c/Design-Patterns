using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class VendorAdapter : ITarget
    {
        public List<string> GetBooks()
        {
            return new Vendor().GetAllVendoreProject().Where(x => x.Contains("book")).ToList();




        }
    }
}
