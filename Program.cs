using System;

namespace soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, sf;

            Console.WriteLine("Ola vamos fazer a soma de 2 numeros");

            Console.Write("Qual é o 1ºValor: ");
            s1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é  o 2ºValor: ");
            s2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            sf = s1 + s2;
            Console.WriteLine($"A soma de {s1} + {s2} = {sf}");
            Console.WriteLine();
        }
    }
}
