using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clicker_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Clicker();

            Console.ReadKey();
        }

        static void Clicker(int clicks = 0)
        {
            Console.WriteLine("Score: " + clicks);
            Console.ReadKey();
            Console.Clear();
            Clicker(clicks + 1);
        }
    }
}
