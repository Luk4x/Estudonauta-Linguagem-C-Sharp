using System;

namespace praticando3
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversão ímplicita int->float (o contrário não funciona de forma implícita)
            int a = 7;
            float b = a;
            show(a, b);

            // conversão explícita float->int
            b = 9.99f;
            a = (int)b; // corta a parte inteira do número apenas.
            show(a, b);

            // conversão por classe auxiliar
            b = 7.99f;
            a = Convert.ToInt32(b); // analisa e pode arredondar o número.
            show(a, b);

            static void show(int a, float b)
            {
                Console.WriteLine("\nb\tvalor: " + b + "\ttipo: " + b.GetType());
                Console.WriteLine("a\tvalor: " + a + "\ttipo: " + a.GetType());
                Console.ReadKey();
            }
        }
    }
}