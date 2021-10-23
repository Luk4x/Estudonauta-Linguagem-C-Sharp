using System;

namespace praticando6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"olá, {nome}.");
            Console.WriteLine($"oláv2, {nome, 20}");
            Console.Write("Digite um salário qualquer: ");
            float sal = 0f;
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"salário formatado: {sal:c}");
            Console.Write("Digite sua idade: ");
            byte idade = 0;
            byte.TryParse(Console.ReadLine(), out idade);
            Console.WriteLine($"Junção do nome({nome, 10}), salário({sal,20:c3}), idade({idade,-4:d3}) e idade hexadecimal({idade:x}) na mesma linha.");
            Console.ReadKey();
        }
    }
}
