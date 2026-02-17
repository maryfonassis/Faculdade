using System;
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0;
            double x = 3.0;
            double y = 2.0;
            while((x <= 99.0) && (y <= 50.0))
            {
                s += (x / y);
                x += 2;
                y++;
            }
            Console.WriteLine(s);
        }
    }
}
