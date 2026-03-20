using System;

namespace Becroowd1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++)
            {
                if (vet[i] >= 10 && vet[i] <= 20)
                {
                    dentro++;
                }
                else fora++;
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
