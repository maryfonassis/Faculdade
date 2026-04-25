namespace Pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente cliente = new Cliente("Maria", "12345678900", "Araxá");
                Vendedor vendedor = new Vendedor("João", 10.0);
                Produto produto = new Produto("Notebook", 3000.0, 1);
                Pagamento pagamento = new Pagamento("Cartão", 2);
                Entrega entrega = new Entrega("Rua A", 10, "Normal");

                Pedido pedido = new Pedido(1, cliente, vendedor, produto, pagamento, entrega);

                pedido.ExibirResumo();
            }
            catch (SystemException e)
            {
                Console.WriteLine("Erro! " + e.ToString());
            }
        }
    }
}
