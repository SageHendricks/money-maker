using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            visuals();

            Console.ReadKey();

        }
        public static void visuals(int health = 100, int hunger = 100, int energy = 100, int light = 100)
        {
            invalid:
            string healthStr = $"{health.ToString()}%";
            string hungerStr = $"{hunger.ToString()}%";
            string energyStr = $"{energy.ToString()}%";
            string lightStr = $"{light.ToString()}%";

            for (int i = healthStr.Length; i <= 5; i++ ) { healthStr = $"{healthStr} "; }
            for (int i = hungerStr.Length; i <= 5; i++ ) { hungerStr = $"{hungerStr} "; }
            for (int i = energyStr.Length; i <= 5; i++ ) { energyStr = $"{energyStr} "; }
            for (int i = lightStr.Length; i < 5; i++ ) { lightStr = $"{lightStr} "; }

            Console.Clear();

            Console.WriteLine($".~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~.");
            Console.WriteLine($"| STATS | HEALTH | HUNGER | ENERGY | LIGHT |");
            Console.WriteLine($"|       | {healthStr} | {hungerStr} | {energyStr} | {lightStr} |");
            Console.WriteLine($"|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine($"|                                          |");
            Console.WriteLine($"| What do you want to do?                  |");
            Console.WriteLine($"| (1) Eat                                  |");
            Console.WriteLine($"| (2) Sleep                                |");
            Console.WriteLine($"| (3) Light Candle                         |");
            Console.WriteLine($"| (4) Wait                                 |");
            Console.WriteLine($"|                                          |");
            Console.WriteLine($"'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");

            Console.Write($" > ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1") { hunger += 30; }
            else if (userChoice == "2") { energy += 110; light -= 30; }
            else if (userChoice == "3") { light = 100; }
            else if (userChoice != "4") { goto invalid; }

            hunger -= 10;
            energy -= 10;
            light -= 20;

            if (health > 100) { health = 100; }
            if (hunger > 100) { hunger = 100; }
            if (energy > 100) { energy = 100; }
            if (light > 100) { light = 100; }

            if (health <= 0 || hunger <= 0 || energy <= 0 || light <= 0) { Console.Clear(); Console.WriteLine("Game Over!"); }
            else { visuals(health, hunger, energy, light); }
         }
    }
}
