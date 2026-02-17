namespace Exercicio5.Entities
{
    internal class Funcionario
    {
        public double SalarioPorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public Funcionario(double salarioPorHora, int horasTrabalhadas)
        {
            SalarioPorHora = salarioPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }
        public double TotalSalario()
        {
            if (HorasTrabalhadas <= (40.0 * 4))
            {
                return HorasTrabalhadas * SalarioPorHora;
            }
            else
            {
                int horasTrabalhadaExtra = HorasTrabalhadas - (40 * 4);
                double salarioBase = 160 * SalarioPorHora;
                double salarioExtra = horasTrabalhadaExtra * (SalarioPorHora + (SalarioPorHora * 50 / 100));
                return salarioExtra + salarioBase;
            }
        }

        public override string ToString()
        {
            return $"Horas trabalhadas: {HorasTrabalhadas}, Salario por hora: {SalarioPorHora}, Total a receber {TotalSalario()}";
        }
    }
}
