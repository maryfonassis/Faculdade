using Exercicio3.Entities;
using System;
using System.Globalization;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sexo M/F: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Pessoa pessoa = new Pessoa(altura, sexo);

            if (pessoa.Sexo == 'F')
            {
                Console.WriteLine($"Peso ideal: {pessoa.PesoIdealFeminino()}");
            }
            else
            {
                Console.WriteLine($"Peso ideal: {pessoa.PesoIdealMasculino()}");

            }
        }
    }
}
