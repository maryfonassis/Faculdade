using System;

namespace SistemaDePedidosSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();
            Loja loja = new Loja();

            produto.Nome = "Hidratante";
            produto.Preco = 120.0;
            produto.Categoria = "Auto cuidado";
            produto.Peso = 1.0;

            cliente.Nome = "Mariany";
            cliente.Cidade = "Araxá";
            cliente.Idade = 19;

            pedido.NumeroPedido = 1;
            pedido.Quantidade = 2;
            pedido.DescontoPercentual = 10;

            loja.Nome = "Pele Bonita";
            loja.Cidade = "Araxá";
            loja.TaxaEntrega = 15;

            double valorBruto = produto.Preco * pedido.Quantidade;
            double valorDesconto = valorBruto * (pedido.DescontoPercentual / 100);
            double valorFinal = valorBruto - valorDesconto;
            double valorTotal = valorFinal + loja.TaxaEntrega;
            double pesoTotal = produto.Peso * pedido.Quantidade;

            Console.WriteLine("-------- SISTEMA DE PEDIDO -----------");

            Console.WriteLine("Produto: " + produto.Nome);
            Console.WriteLine("Categoria: " + produto.Categoria);
            Console.WriteLine("Cliente: " + cliente.Nome);
            Console.WriteLine("Cidade: " + cliente.Cidade);
            Console.WriteLine("Quantidade: " + pedido.Quantidade);
            Console.WriteLine("Valor Bruto: " + valorBruto);
            Console.WriteLine("Valor Desconto: " + valorDesconto);
            Console.WriteLine("Valor Final: " + valorFinal);
            Console.WriteLine("Taxa Entrega: " + loja.TaxaEntrega);
            Console.WriteLine("Valor Total: " + valorTotal);
            Console.WriteLine("Peso Total: " + pesoTotal + " kg");
        }
    }
}
