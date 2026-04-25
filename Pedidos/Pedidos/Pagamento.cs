namespace Pedidos
{
    internal class Pagamento
    {
        public string FormaPagamento { get; set; }
        private int parcelas;
        public int Parcelas 
        {
            get { return parcelas; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Deve ter pelo menos 1 parcela");
                else
                    parcelas = value;
            }
        }

        public Pagamento(string formaPagamento, int parcelas)
        {
            FormaPagamento = formaPagamento;
            Parcelas = parcelas;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Forma: {FormaPagamento}, Parcelas: {Parcelas}");
        }

        public bool ValidarPagamento()
        {
            return !string.IsNullOrEmpty(FormaPagamento) && Parcelas > 0;
        }

        public double CalcularAcrescimo(double valorBase)
        {
            if (Parcelas > 1)
            {
                return valorBase * 0.05;
            }
            return 0;
        }
    }
}
