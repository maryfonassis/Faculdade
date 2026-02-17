using Exercicio5.Entities;
using System;
using System.Globalization;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario por hora: ");
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionario = new Funcionario(salarioHora, horas);
            Console.WriteLine(funcionario);
        }
    }
}
