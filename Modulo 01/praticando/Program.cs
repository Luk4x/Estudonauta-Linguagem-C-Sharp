using System;

namespace praticando
{
    class Program
    {
        /// <summary>
        /// ......
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("a,\a\nb\n\tc\n\"d\"\n\\ee\b\\");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"\f\");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("g");
            Console.ReadKey();
        }
    }
}
