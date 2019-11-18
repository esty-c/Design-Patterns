using System;
using System.Collections.Generic;

namespace AdapterDesignPattern
{
    public  class Vendor
    {
        public List<String> GetAllVendoreProject()
        {
            var list = new List<string>();
            list.Add("game: Age of empires ");
            list.Add("game: Commandos ");
            list.Add("game: Desparados ");

            list.Add("book: The Woman in the Window ");
            list.Add("book: The Great Alone  ");
            list.Add("book: The Tattooist of Auschwitz ");

            return list;
        }
    }
}