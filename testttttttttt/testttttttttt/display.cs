using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testttttttttt
{
    class Display
    {
        public static void display(string text, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            //WriteAt(message2, x, y);
        }
    }
}
