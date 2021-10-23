using System;
using System.Threading;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nSorteador de número\n---------------------------\nInicio: ");
            int n1 = 0, n2 = 0;
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out n2);
            Console.Write("---------------------------\nSorteando...");
            Random ger = new Random();
            Thread.Sleep(1000);
            for (byte i = 0; i <= 11; i++) 
            {
                Console.Write("\b");
            }
            Console.Write($"Entre {n1} e {n2}, sorteei o valor {ger.Next(n1,n2+1)}.");
            Console.ReadKey();

        }
    }
}
