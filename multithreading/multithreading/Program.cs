using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            my_threading.RunAllTheThreads();
            //my_threading.countDown();
            //my_threading.countUp();
            Console.WriteLine("Yoyo!");
            Console.ReadKey();
        }
    }
}
