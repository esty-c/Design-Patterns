using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMobileByName("lala");
        }







        public static IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = NullMobile.Instance;
            switch (mobileName)
            {
                case "sony":
                    mobile = new SamsungGalaxy();
                    break;

                case "apple":
                    mobile = new SamsungGalaxy();
                    break;

                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;
            }
            return mobile;
        }
    }
    public interface IMobile
    {
        void TurnOn();
        void TurnOff();
    }
    public class SamsungGalaxy : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\nSamsung Galaxy Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nSamsung Galaxy Turned ON!");
        }
    }



    public class NullMobile : IMobile
    {
        private static NullMobile _instance;

        public static NullMobile Instance
        {
            get {
                if (_instance == null)
                {
                    return new NullMobile();
                }
                return _instance;
            }
        }
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }





}
