using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold = 10;
            int silver = 5;

            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("how many coins would you like to convert?");
            double coins = Math.Floor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(Convert.ToString(coins) + " cents is equal to...");

            double goldCoins = Math.Floor(coins / gold);
            double remainder = coins % gold;
            double silverCoins = Math.Floor(remainder / silver);
            remainder = remainder % silver;

            Console.WriteLine("Gold Coins: " + Convert.ToString(goldCoins));
            Console.WriteLine("Silver Coins: " + Convert.ToString(silverCoins));
            Console.WriteLine("Bronze Coins: " + Convert.ToString(remainder));
            Console.ReadKey();
        }
    }
}
