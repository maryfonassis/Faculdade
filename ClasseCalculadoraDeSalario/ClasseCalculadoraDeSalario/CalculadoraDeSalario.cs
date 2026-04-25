using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCalculadoraDeSalario
{
    internal class CalculadoraDeSalario
    {
        public string NomeFuncionario { get; set; }
        public double SalarioBase { get; set; }
        public double SalarioFinal { get; set; }

        public CalculadoraDeSalario()
        {
        }

        public CalculadoraDeSalario(string nomeFuncionario, double salarioBase, double salarioFinal)
        {
            NomeFuncionario = nomeFuncionario;
            SalarioBase = salarioBase;
            SalarioFinal = salarioFinal;
        }
        public void ReceberDados()
        {
            Console.Write("Nome do Funcionario: ");
            NomeFuncionario = Console.ReadLine();
            Console.Write("Salário Base: ");
            SalarioBase = double.Parse(Console.ReadLine());
        }
        public void CalcularAumento(double percentual)
        {
            SalarioFinal += percentual/100;
        }
        public void CalcularDesconto(double percentual)
        {
            SalarioFinal -= percentual/100;
        }
        public void MostrarSalario()
        {
            Console.WriteLine($"{NomeFuncionario}, Salário base: {SalarioBase.ToString("F2")} | Salário final: {SalarioFinal.ToString("F2")}");
        }
    }
}
