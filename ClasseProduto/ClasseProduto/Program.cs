namespace ClasseProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.ReceberDados();
            produto.AdicionarEstoque(2);
            produto.RemoverEstoque(1);
            produto.MostrarProduto();

        }
    }
}
