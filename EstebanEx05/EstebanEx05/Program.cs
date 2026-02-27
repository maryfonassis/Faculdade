using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebanEx05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
           
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} é o maior número");
            }
            else if (b > c)
            {
                Console.WriteLine($"{b} é o maior número");

            }
            else
            {
                Console.WriteLine($"{c} é o maior número");

            }

            int soma = a + b + c;
            if (soma % 2 == 0)
            {
                Console.WriteLine($"A soma é: {soma}, Par");

            }
            else
            {
                Console.WriteLine($"A soma é: {soma}, Impar");

            }
        }
    }
}
