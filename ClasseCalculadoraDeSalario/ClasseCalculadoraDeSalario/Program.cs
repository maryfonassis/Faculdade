namespace ClasseCalculadoraDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadoraDeSalario = new CalculadoraDeSalario();
            calculadoraDeSalario.ReceberDados();
            calculadoraDeSalario.CalcularAumento(10.0);
            calculadoraDeSalario.CalcularDesconto(5.0);
            calculadoraDeSalario.MostrarSalario();
        }
    }
}
