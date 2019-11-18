using System;
namespace MomentoDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {

         
            Originator<string> orig = new Originator<string>();
            orig.State = "State0";
            Caretaker<string>.SaveState(orig);
            Console.WriteLine(orig.State);

            orig.State = "State1";
            Caretaker<string>.SaveState(orig);
            Console.WriteLine(orig.State);

            orig.State = "State2";
            Caretaker<string>.SaveState(orig);
            Console.WriteLine(orig.State);

            orig.State = "State3";
            Caretaker<string>.SaveState(orig);
            Console.WriteLine(orig.State);

            Caretaker<string>.RestoreState(orig, 2);
            Console.WriteLine(orig.State);
            Console.ReadLine();


        }
    }
}