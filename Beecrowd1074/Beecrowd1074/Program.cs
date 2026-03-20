using System;
namespace Beecrowd1074
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
            string positivoNegativo;
            string parImpar;

            for (int i = 0; i< n; i++)
            {
                if (vet[i] == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    parImpar = vet[i] % 2 == 0 ? "EVEN" : "ODD";
                    positivoNegativo = vet[i] > 0 ? "POSITIVE" : "NEGATIVE";
                    Console.WriteLine($"{parImpar} {positivoNegativo}");
                }

            }
        }
    }
}
