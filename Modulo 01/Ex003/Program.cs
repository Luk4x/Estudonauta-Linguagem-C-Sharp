using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nDigite um número real: ");
            float num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"--------------------------\nVocê digitou o número {num:N3}\nA parte inteira dele é {(UInt16)num}\nArredondando, temos {Convert.ToUInt16(num)}");
            Console.ReadKey();
        }
    }
}
