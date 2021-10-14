using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adenture
{
    class story
    {
        public static int MakePrompt(string prompt, List<string> choices, string correct )
        {
            string correctNum = "a";

            Console.WriteLine(prompt);
            Console.Write($"choices: ");
            for ( int i = 0; i < choices.Count; i++) { Console.Write($"\"({i}) {choices[i]}\", "); }
            Console.Write("\n > ");

            string userChoice = Console.ReadLine();
            for ( int i = 0; i < choices.Count; i++ )
            {
                if (choices[i] == correct)
                {
                    correctNum = i.ToString();
                    break;
                }
            }

            Console.Clear();
            int value; 
            if ( correctNum == "a" ) { value = 1; }
            else if ( userChoice == correctNum) { value = 1; }
            else { value = 0; }

            return value;
        }
       
    }
}
