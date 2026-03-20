using System;

namespace Beecrowd1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cont++;
                    if (cont % 4 != 0)
                        Console.Write(cont + " ");
                    else Console.WriteLine("PUM");
                }

            }
        }
    }
}
