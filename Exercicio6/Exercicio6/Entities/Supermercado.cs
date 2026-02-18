
using System.Collections.Generic;

namespace Exercicio6.Entities
{
    internal class Supermercado
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Supermercado()
        {
        }

        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void AjustarPreco()
        {
            foreach (Produto produto in Produtos)
            {
                if(produto.MediaMensal < 500 && produto.Preco < 30.0)
                {
                    produto.Preco += produto.Preco * 0.10;
                }
                else if ((produto.MediaMensal >= 500.0) &&  (produto.Preco >= 30.0))
                {
                    produto.Preco -= produto.Preco * 0.20;
                }
            }
        }
    }
}
