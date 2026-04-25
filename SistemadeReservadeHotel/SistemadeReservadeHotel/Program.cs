using System;

class Program
{
    static void Main(string[] args)
    {
        Hospede hospede = new Hospede();
        Reserva reserva = new Reserva();

        hospede.ReceberDados();
        hospede.MostrarDados();

        Console.Write("Digite novo telefone: ");
        string novoTel = Console.ReadLine();
        hospede.AtualizarTelefone(novoTel);

        hospede.MostrarDados();

        reserva.ReceberDadosReserva();
        reserva.CalcularTotal();

        Console.Write("\nDigite o percentual de desconto: ");
        double desconto = double.Parse(Console.ReadLine());
        reserva.AplicarDesconto(desconto);

        reserva.MostrarReserva();
    }
}