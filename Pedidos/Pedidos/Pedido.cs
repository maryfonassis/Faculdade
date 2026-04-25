namespace Pedidos
{
    internal class Pedido
    {
        public int Numero { get; private set; }
        public Cliente Cliente { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Produto Produto { get; private set; }
        public Pagamento Pagamento { get; private set; }
        public Entrega Entrega { get; private set; }

        public Pedido(int numero, Cliente cliente, Vendedor vendedor, Produto produto, Pagamento pagamento, Entrega entrega)
        {
            Numero = numero;
            if (cliente == null)
            {
                throw new ArgumentNullException("Cliente não pode ser nulo");
            }
            else
            {
                Cliente = cliente;
            }

            if (vendedor == null)
            {
                throw new ArgumentNullException("Vendedor não pode ser nulo");
            }
            else
            {
                Vendedor = vendedor;
            }

            if (produto == null)
            {
                throw new ArgumentNullException("Produto não pode ser nulo");
            }
            else
            {
                Produto = produto;
            }
            if (pagamento == null)
            {
                throw new ArgumentNullException("Pagamento não pode ser nulo");
            }
            else
            {
                Pagamento = pagamento;
            }
            if (entrega == null)
            {
                throw new ArgumentNullException("Entrega não pode ser nulo");
            }
            else
            {
                Entrega = entrega;
            }


        }

        public double CalcularValorFinal()
        {
            double subtotal = Produto.CalcularSubtotal();
            double taxaEntrega = Entrega.CalcularTaxaEntrega();
            double acrescimo = Pagamento.CalcularAcrescimo(subtotal);

            return subtotal + taxaEntrega + acrescimo;
        }

        public double CalcularComissaoVendedor()
        {
            double valorFinal = CalcularValorFinal();
            return Vendedor.CalcularComissao(valorFinal);
        }

        public void ExibirResumo()
        {
            Console.WriteLine("=== RESUMO DO PEDIDO ===");

            Cliente.ExibirDados();
            Vendedor.ExibirDados();
            Produto.ExibirDados();
            Pagamento.ExibirDados();
            Entrega.ExibirDados();

            Console.WriteLine($"Valor Final: {CalcularValorFinal():F2}");
            Console.WriteLine($"Comissão do Vendedor: {CalcularComissaoVendedor():F2}");
        }

    }
}
