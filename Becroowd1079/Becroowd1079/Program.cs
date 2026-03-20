using System;
using System.Globalization;


namespace Becroowd1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }   
}
