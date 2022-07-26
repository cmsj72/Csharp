using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스마트밥솥
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);
            Random rand = new Random();
            ConsoleColor[] Color = {ConsoleColor.Blue, ConsoleColor.Cyan,
            ConsoleColor.DarkRed, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Magenta,
            ConsoleColor.Gray};

            while (true)
            {
                Console.Clear();
                for(int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = Color[rand.Next(7)];
                    Console.SetCursorPosition(rand.Next(100), rand.Next(40));
                    Console.Write("Hello World");
                }
            }
        }
    }
}
