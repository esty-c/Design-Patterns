using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Bullethit(3);
            player.Bullethit(9);
            player.Bullethit(12);

            Console.ReadLine();
        }
    }
}
