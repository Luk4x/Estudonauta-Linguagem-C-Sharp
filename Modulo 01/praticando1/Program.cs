using System;

namespace praticando1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores inteiros
            Console.WriteLine("byte=\tMin: " + byte.MinValue + "\t\t\t\tMax: " + byte.MaxValue); // Ambos usam 1 byte (8 bits)
            Console.WriteLine("sbyte=\tMin: " + sbyte.MinValue + "\t\t\tMax: " + sbyte.MaxValue);

            Console.WriteLine("short=\tMin: " + short.MinValue + "\t\t\tMax: " + short.MaxValue); // Ambos usam 2 bytes (16 bits)
            Console.WriteLine("ushort=\tMin:" + ushort.MinValue + "\t\t\t\tMax: " + ushort.MaxValue);

            Console.WriteLine("int=\tMin: " + int.MinValue + "\t\tMax: " + int.MaxValue); // Ambos usam 4 bytes (32 bits)
            Console.WriteLine("uint=\tMin: " + uint.MinValue + "\t\t\t\tMax: " + uint.MaxValue);

            Console.WriteLine("long=\tMin: " + long.MinValue + "\tMax: " + long.MaxValue); // Ambos usam 8 bytes (64 bits)
            Console.WriteLine("ulong=\tMin: " + ulong.MinValue + "\t\t\t\tMax: " + ulong.MaxValue);

            // Valores reais
            Console.WriteLine("\nfloat=\tMin: " + float.MinValue + "\t\t\tMax: " + float.MaxValue); // Usa 4 bytes (16 bits)
            Console.WriteLine("double=\tMin: " + double.MinValue + "\t\tMax: " + double.MaxValue); // Usa 8 bytes (64 bits)
            Console.WriteLine("decimal\tMin: " + decimal.MinValue + "\tMax: " + decimal.MaxValue); // Usa 16 bytes (128 bits)

            // Valores lógicos
            Console.Write("\nbool=\t" + bool.FalseString + " ou " + bool.TrueString); // Usa 1 BIT
            Console.ReadKey();
        }
    }
}
