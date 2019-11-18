using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoDesignPattern
{
    public class Caretaker<T>
    {
        public static List<Memento<T>> list = new List<Memento<T>>();

        public static void SaveState(Originator<T> obj)
        {
            list.Add(obj.CreateMomento());
        
        }



        public static void RestoreState(Originator<T> orig, int stateNumber)
        {
            orig.State = list[stateNumber].State;
           // orig.SetMomento(list[stateNumber]);
        
        }





    }
}
