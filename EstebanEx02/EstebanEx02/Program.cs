using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static double D(int a, int b, int c)
        {
            return (R(a, b) + S(b, c)) / 2;
        }
        static double R(int a, int b)
        {
            return Math.Pow((a + b), 2);
        }

        static double S(int b, int c)
        {
            return Math.Pow((b + c), 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros:");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {D(a, b, c).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}