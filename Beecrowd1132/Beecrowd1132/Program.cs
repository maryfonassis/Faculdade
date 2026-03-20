using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());


        int soma = 0;

        for (int i = x; i <= y; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}
