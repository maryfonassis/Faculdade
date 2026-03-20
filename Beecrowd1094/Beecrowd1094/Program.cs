using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int total = 0;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int quantidade = int.Parse(entrada[0]);
            total += quantidade;
            char tipo = entrada[1][0];
            if (tipo == 'C')
                coelhos += quantidade;
            else if (tipo == 'R')
                ratos += quantidade;
            else if (tipo == 'S')
                sapos += quantidade;
        }

        double percCoelhos = (double)coelhos * 100.0 / total;
        double percRatos = (double)ratos * 100.0 / total;
        double percSapos = (double)sapos * 100.0 / total;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {percCoelhos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {percRatos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {percSapos.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}