using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da2sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sofware is exsisting");

            Console.WriteLine("enter number1");
            int yourNumber1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter number2");
            int yourNumber2 = Int32.Parse(Console.ReadLine());

            int pickles = ReturnMultiply(yourNumber1, yourNumber2);
            Console.WriteLine(pickles);
            if (pickles % 2 == 0) { Console.WriteLine("even"); }
            else { Console.WriteLine("odd"); }

            Console.ReadKey();
        }

        static void SampleMethod()
        {
            Random numGen = new Random();
            int number = numGen.Next(0,21);
            Console.Write($"{number}");
            Console.ReadKey();
            Console.Write($"\n");
            SampleMethod();
        }

        static void meatAllan()
        {
            Random numGen = new Random();
            string name = "X-" + numGen.Next(10, 999999999);
            int age = numGen.Next(10, 500);

            Console.WriteLine($"Howdy, I'm {name}.");
            Console.WriteLine($"I'm {age} years old.");
            Console.WriteLine($"oh an im an allen.");
            //Console.ReadKey();
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            meatAllan();

        }

        static void Parameter(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }

        static int ReturnMultiply(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
    }
}
