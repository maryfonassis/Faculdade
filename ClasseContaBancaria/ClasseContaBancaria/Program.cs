using ExClasseContaBancaria.Entities;
using System;
using System.Globalization;

namespace ClasseContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.ReceberDados();
            Console.Write("Quanto deseja depositar: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposita(deposito);
            Console.Write("Quanto deseja sacar: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(saque);
            contaBancaria.MostrarSaldo();
        }
    }
}