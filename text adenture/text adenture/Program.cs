using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adenture
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            while ( true ) {
                answer = story.MakePrompt(
                    "You wake up. There is a note sayig your dog has been stolen. you think \"NO NOT GEORGE CIX\" what do you do?",
                    new List<string>() { "Go Back To Sleep", "Ignore it", "A D V E N T U R E!!!!" },
                    "A D V E N T U R E!!!!"
                );
                if (answer == 0) { break; }
                answer = story.MakePrompt(
                     "You leave the house to go non an adventure, where do you go?",
                     new List<string>() { "Back inside", "To Your neighbors", "the woods", "the cave", "the local village" },
                     "the local village"
                 );
                if (answer == 0){ break; }
                answer = story.MakePrompt(
                    "You go to the village and see a few people standing around",
                    new List<string>() { "George XV", "George jr.", "George LVX", "George" },
                    "George XV"
                );
                if (answer == 0) { break; }
                answer = story.MakePrompt(
                    "you go up to George XV and he says \"Hey whats up George VI!!! Howre you????\" How do you respond?",
                    new List<string>() { "Acuse him of taking you dog George CIX", "slap him", "Shank him", "explain someone stole your dog" },
                    "Shank him"
                );
                if (answer == 0) { break; }
                answer = story.MakePrompt(
                    "you, George VI, shank George XV while George jr., George LVX, and George stand in confusion. all the while the now shanked George XV Coughs up blood what do you do?",
                    new List<string>() { "apoligize", "stab it deeper", "punch him in the stomach" },
                    "punch him in the stomach"
                );
                if (answer == 0) { break; }
                Console.WriteLine("George XV falls to the ground and throws up peices of dog fur. you see, slap him, fall to the ground and break down. the town of Georges stare in greater confusion. as you die of sadness due to you past freind George XV eating your dog.");
                break;
            }
            if ( answer == 1 ) { Console.WriteLine("You WIN!!! CONGRATS"); } 
            else { Console.WriteLine("You Lose,,"); }
            Console.ReadLine();
        }
    }
}
