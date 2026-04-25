namespace Pedidos
{
    internal class Produto
    {
        public string Descricao { get; set; }

        private double precoUnitario;
        public double PrecoUnitario 
        {
            get
            {
                return precoUnitario;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Preço Inválido");
                else
                    precoUnitario = value;
            }
        }


        private int quantidade;
        public int Quantidade 
        { 
            get {  return quantidade; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantidade Inválida");
                else
                    quantidade = value;
            }
        }

        public Produto(string descricao, double precoUnitario, int quantidade)
        {
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Descricao}, Preço: {PrecoUnitario}, Quantidade: {Quantidade}");
        }

        public double CalcularSubtotal()
        {
            return PrecoUnitario * Quantidade;
        }

    }
}
