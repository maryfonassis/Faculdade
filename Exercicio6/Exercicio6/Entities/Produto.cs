
namespace Exercicio6.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double MediaMensal { get; set; }

        public Produto(string nome,double preco, double mediaMensal)
        {
            Nome = nome;
            Preco = preco;
            MediaMensal = mediaMensal;
        }

        public override string ToString()
        {
            return Nome + " " + Preco;
        }
    }
}
