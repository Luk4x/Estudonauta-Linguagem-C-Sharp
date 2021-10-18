using System;

namespace praticando2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            var n = 0; // não é possivel fazer "var = n;" pois o var precisa de uma inicialização para a partir dela inferir o tipo.
            int i;
            byte idade = 17;
            string nome = "Lucas";
            bool dia = true;
            ushort ushortMax = 65535;
            float media = 8.4f;
            double media2 = media * 20;
            decimal media3 = 9.968594839473347M;
            var media3cpy = 9.968594839473347M;
            i = 0;

            Console.WriteLine("n\t\ttipo: " + n.GetType() + "\nidade\t\ttipo: " + idade.GetType());
            Console.WriteLine("nome\t\ttipo: " + nome.GetType() + "\ndia\t\ttipo: " + dia.GetType());
            Console.WriteLine("media\t\ttipo: " + media.GetType() + "\nushortMax\ttipo: " + ushortMax.GetType());
            Console.WriteLine("media2\t\ttipo: " + media2.GetType() + "\nmedia3\t\ttipo: " + media3.GetType());
            Console.WriteLine("media3cpy\ttipo: " + media3cpy.GetType() + "\ni\t\ttipo: " + i.GetType());
            Console.WriteLine("pi (math)\ttipo: " + Math.PI.GetType());
            Console.ReadKey();

            // constantes
            const string OBJETIVO = "evoluir em programação";
            Console.WriteLine("\n\nMeu objetivo é " + OBJETIVO);
            Console.ReadKey();
        }
    }
}
