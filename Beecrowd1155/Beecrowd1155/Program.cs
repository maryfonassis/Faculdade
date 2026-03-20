using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double s = 0.0;

        for (int i = 1; i <= 100; i++)
        {
            s += 1.0 / i;
        }

        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}
