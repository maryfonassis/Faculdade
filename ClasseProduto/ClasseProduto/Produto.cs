using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    internal class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto()
        {
        }

        public Produto(int codigoProduto, string nomeProduto, double preco, int quantidadeEstoque)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
        public void ReceberDados()
        {
            Console.Write("Codigo do produto: ");
            CodigoProduto = int.Parse(Console.ReadLine());
            Console.Write("Nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write("Preço do produto: ");
            Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            QuantidadeEstoque = int.Parse(Console.ReadLine());
        }
        public void AdicionarEstoque(int add)
        {
            QuantidadeEstoque += add;
        }
        public void RemoverEstoque(int remover)
        {
            QuantidadeEstoque -= remover;
        }
        public void MostrarProduto()
        {
            Console.WriteLine($"{CodigoProduto}, {NomeProduto}| preço: {Preco.ToString("F2")}, Estoque: {QuantidadeEstoque}");
        }

    }
}
