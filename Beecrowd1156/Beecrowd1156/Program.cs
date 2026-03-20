using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double s = 0.0;
        double denominador = 1.0;

        for (int numerador = 1; numerador <= 39; numerador += 2)
        {
            s += numerador / denominador;
            denominador *= 2.0;
        }

        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}