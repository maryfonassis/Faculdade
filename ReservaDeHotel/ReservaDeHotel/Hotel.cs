namespace ReservaDeHotel
{
    internal class Hotel
    {
        public enum Status
         {
            Cancelada,
            Ativa
         }
        public string NomeHospede { get; set; }
        public int NumeroDoQuarto { get; set; }
        public int Diarias { get; set; }
        public double ValorDiaria { get; set; }
        public Status StatusReserva { get; set; }

        public Hotel(string nomeHospede, int numeroDoQuarto)
        {
            StatusReserva = Status.Ativa;
            Diarias = 1;
            ValorDiaria = 50.0;

            if (nomeHospede == null)
                NomeHospede = "óspede não informado";

            if (numeroDoQuarto <= 0)
                NumeroDoQuarto = 1;

        }

        public Hotel(string nomeHospede, int numeroDoQuarto, int diarias, double valorDiaria)
        {
            Diarias = diarias;
            ValorDiaria = valorDiaria;
            StatusReserva = Status.Ativa;

            if (nomeHospede == null)
                NomeHospede = "óspede não informado";

            if (numeroDoQuarto <= 0)
                NumeroDoQuarto = 1;

            if (valorDiaria <= 0)
                ValorDiaria = 50.0;
        }
        public double CalcularTotal()
        {
            return Diarias * ValorDiaria;
        }
        public void ExibirReserva()
        {
            Console.WriteLine(NomeHospede + " Quarto: " + NumeroDoQuarto);
            Console.WriteLine($"Diárias: {Diarias}| Preço diária: {ValorDiaria}| Total: {CalcularTotal()}");
            Console.WriteLine($"Status: {StatusReserva.ToString()}");
        }
        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                Diarias += quantidade;
            }
        }
        public void CancelarReserva()
        {
            StatusReserva = Status.Cancelada;
        }
        public void ReativarReserva()
        {
            StatusReserva = Status.Ativa;
        }

    }
}
