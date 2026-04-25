using System;

public class Reserva
{
    public int NumeroReserva { get; set; }
    public int QuantidadeDiarias { get; set; }
    public double ValorDiaria { get; set; }
    public double ValorTotal { get; set; }

    public void ReceberDadosReserva()
    {
        Console.Write("Número da reserva: ");
        NumeroReserva = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de diárias: ");
        QuantidadeDiarias = int.Parse(Console.ReadLine());

        Console.Write("Valor da diária: ");
        ValorDiaria = double.Parse(Console.ReadLine());
    }

    public void CalcularTotal()
    {
        ValorTotal = QuantidadeDiarias * ValorDiaria;
    }

    public void AplicarDesconto(double percentual)
    {
        ValorTotal -= ValorTotal * (percentual / 100);
    }

    public void MostrarReserva()
    {
        Console.WriteLine("--- Dados da Reserva ---");
        Console.WriteLine($"Número: {NumeroReserva}");
        Console.WriteLine($"Diárias: {QuantidadeDiarias}");
        Console.WriteLine($"Valor da diária: {ValorDiaria}");
        Console.WriteLine($"Valor total: {ValorTotal}");
    }
}