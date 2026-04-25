namespace Pedidos
{
    internal class Entrega
    {
        public string Endereco { get; set; }

        private double distanciaKm;
        public double DistanciaKm 
        {
            get { return distanciaKm; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("A distancia não pode ser um valor negativo");
                else 
                    distanciaKm = value;
            }
        }
        public string TipoEntrega { get; set;}

        public Entrega(string endereco, double distanciaKm, string tipoEntrega)
        {
            Endereco = endereco;
            DistanciaKm = distanciaKm;
            TipoEntrega = tipoEntrega;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Endereço: {Endereco}, Distância: {DistanciaKm}km, Tipo: {TipoEntrega}");
        }

        public double CalcularTaxaEntrega()
        {
            return DistanciaKm * 2;
        }

    }
}
