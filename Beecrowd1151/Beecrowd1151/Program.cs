using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
                Console.Write(a);
            else
                Console.Write(a + " ");

            int proximo = a + b;
            a = b;
            b = proximo;
        }

        Console.WriteLine();
    }
}