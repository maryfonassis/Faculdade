
namespace Pedidos
{
    internal class Vendedor
    {
        public string Nome { get; set; }
        public string Matricula 
        {
            get
            {
                return Nome + "10";
            }
        }

        private double comissaoPercentual;
        public double ComissaoPercentual
        {
            get { return comissaoPercentual; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Percentual Inválido");
                else
                    comissaoPercentual = value;

            }
        }

        public Vendedor(string nome, double comissaoPercentual)
        {
            Nome = nome;
            ComissaoPercentual = comissaoPercentual;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Comissão: {ComissaoPercentual}%");
        }

        public double CalcularComissao(double valorPedido)
        {
            return valorPedido * (ComissaoPercentual / 100);
        }


    }
}
