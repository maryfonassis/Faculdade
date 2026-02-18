using Exercicio6.Entities;
using System;
using System.Globalization;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermercado supermercado = new Supermercado();
            Console.WriteLine("Quantos produtos deseja adicionar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Venda media: ");
                double media = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto produto = new Produto(nome, preco, media);
                supermercado.AddProduto(produto);
            }

            supermercado.AjustarPreco();
            Console.WriteLine("Preço atualizado: ");
            foreach (Produto produto in supermercado.Produtos)
            {
                Console.WriteLine(produto.ToString());
            }
        }
    }
}
