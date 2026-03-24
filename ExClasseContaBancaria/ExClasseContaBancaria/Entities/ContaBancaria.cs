using System;
using System.Globalization;

namespace ExClasseContaBancaria.Entities
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public void ReceberDados() 
        {
            Console.Write("Número da conta: ");
            NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            NomeTitular = Console.ReadLine();
            Console.Write("Saldo: ");
            Saldo = double.Parse(Console.ReadLine());
        }
        public void Deposita(double deposito)
        {
            Saldo += deposito;
        }
        public void Sacar(double saque)
        {
            Saldo -= saque;
        }
        public void MostrarSaldo()
        {
            Console.Write($"Número da conta: {NumeroConta}");
            Console.Write($"Nome do Titular: {NomeTitular}");
            Console.WriteLine($"Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
