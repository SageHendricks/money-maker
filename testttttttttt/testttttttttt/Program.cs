using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace testttttttttt
{
    class Program
    {


        static void Main(string[] args)
        {
            Cursor.Hide();

            string[] message = new string[] { "wwwwwwwwwwwwwwwwwwwwwwwwwww", "w                         w", "w                         w", "w                         w", "w                         w", "wwwwwwwwwwwwwwwwwwwwwwwwwww", "" };

            int n = 0;

            int FPS = 60;
            while (true)
            {
                Display.display(String.Join("\n", message));
                Console.WriteLine(n/FPS);
                n++;
                if (n == FPS * 3)
                {
                    message[2] = "eeeeeeeeeeeeeeeeeeeeeeeeeee";
                }
            }
        }

        
    }
}
