using System;
using System.Threading;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 5);
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" MEU ");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" BRASIL ");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" BRASILEIRO ");
            Console.ReadKey();
        }
    }
}
