using System;

namespace praticando4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("ola, " + nome + ".\nDigite um número: ");
            byte num = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\"" + num + "\"? nice.");
            Console.ReadKey();
        }
    }
}
