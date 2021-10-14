using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading
{
    class my_threading
    {
        static Thread thread1 = new Thread(countDown);
        static Thread thread2 = new Thread(countUp);

        public static void RunAllTheThreads()
        {
            thread1.Start();
            thread2.Start();
        }

        public static void countDown()
        {
            for(int i = 8; i > 0; i--)
            {
                Console.WriteLine($"Timer Number 1: {i} seconds.");
                //Thread.Sleep(0);
            }
        }
        public static void countUp()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Timer Number 2: {i} seconds.");
                //Thread.Sleep(4000);
            }
        }
    }
}
