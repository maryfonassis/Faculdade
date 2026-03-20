using System;

namespace Beecrowd1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int .Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}
