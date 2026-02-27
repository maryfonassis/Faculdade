using System;
using System.Globalization;

namespace EstebanEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as 3 notas do aluno:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/3.0;

            Console.WriteLine($"A média ponderada é: {media}");
        }
    }
}
