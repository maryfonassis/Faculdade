using System;

namespace Becroowd1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;
            if (x <= y)
            {
                for (int i = x+1; i <= y-1; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = y+1; i <= x-1; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }

                }
            }
            Console.WriteLine(soma);
        }
    }
}
