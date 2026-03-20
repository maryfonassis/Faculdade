using System;

namespace Beecrowd1133
{
    internal class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            for (int i = x + 1; i <= y - 1; i++)
            {
                int resto = i % 5;

                if (resto == 2 || resto == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

