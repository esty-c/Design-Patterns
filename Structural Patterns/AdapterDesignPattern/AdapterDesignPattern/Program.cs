﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ITarget adapter = new VendorAdapter();

            foreach (var r in adapter.GetBooks())
            {
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }
}
