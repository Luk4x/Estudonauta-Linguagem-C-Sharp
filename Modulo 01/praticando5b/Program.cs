using System;
using System.Threading;

namespace praticando5b
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();

            Thread.Sleep(400);
            Console.WriteLine("gerando número de 0 a 10: (" + gerador.Next(11) + ")");
            Thread.Sleep(400);
            Console.WriteLine("gerando número de 20 a 40: (" + gerador.Next(20, 41) + ")");
            Thread.Sleep(400);
            Console.WriteLine("gerando número de 50 a 90: (" + gerador.Next(50, 90) + ")");
            Thread.Sleep(400);
            Console.WriteLine("gerando número de 100 a 160: (" + gerador.Next(100, 160) + ")\n\n");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Thread.Sleep(1000);
            Console.WriteLine("Dia atual: " + dia);
            Thread.Sleep(1000);
            Console.WriteLine("Mês atual: " + mes);
            Thread.Sleep(1000);
            Console.WriteLine("Ano atual: " + ano);
            Console.ReadKey();
        }
    }
}
