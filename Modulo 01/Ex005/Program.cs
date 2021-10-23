using System;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEm que ano você nasceu? ");
            ushort nasc = 0;
            ushort.TryParse(Console.ReadLine(), out nasc);
            Console.WriteLine($"--------------------------------------------\nEstamos atualmente em {DateTime.Now.Year}.");
            Console.WriteLine($"Se você nasceu em {nasc}, então deve ter {DateTime.Now.Year-nasc} anos.");
            Console.ReadKey();
        }
    }
}
