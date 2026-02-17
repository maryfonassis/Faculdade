using System;

namespace DistanciaEntreDoisPontos
{
    internal class Program
    {
        static double Distancia(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite P(x1, y1)");
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite P(x2, y2)");
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Distancia: {Distancia(x1, y1, x2, y2)}");


        }
    }
}
