using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooo_pretty_colours
{
    public class Window
    {
        public int Width = Console.WindowWidth;
        public int Height = Console.WindowHeight;
    }
    class Colours
    {
        public static void map()
        {
            List<List<ConsoleColor>> map = new List<List<ConsoleColor>>();

            Window pic = new Window();
            int width = pic.Width;
            int height = pic.Height;

            map = backgroundColor(map, width, height, ConsoleColor.Blue);

            map = PixelColor(map, 8, 4, ConsoleColor.White);

            display(map);
        }

        private static List<List<ConsoleColor>>  backgroundColor(List<List<ConsoleColor>> map, int width, int height, ConsoleColor color)
        {
            for (int Y = 0; Y < height/2; Y++)
            {
                map.Add(new List<ConsoleColor>());
                for (int X = 0; X < width; X++)
                {
                    map[Y].Add(color);
                }
            }
            return map;

        }

        private static List<List<ConsoleColor>> PixelColor (List<List<ConsoleColor>> map, int X, int Y, ConsoleColor color)
        {
            map[Y][X] = color;
            return map;
        }
        
        private static void display(List<List<ConsoleColor>> map)
        {
            for (int Y = 0; Y < map.Count; Y++)
            {
                for (int X = 0; X < map[Y].Count; X++)
                {
                    Console.BackgroundColor = map[Y][X];
                    Console.Write("  ");
                    Console.ResetColor();
                }
            }
        }
    }
}
