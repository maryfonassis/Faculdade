namespace Pedidos
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }

        public Cliente(string nome, string cPF, string cidade)
        {
            Nome = nome;
            CPF = cPF;
            Cidade = cidade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Cidade: {Cidade}");
        }

        public string RetornarApresentacao()
        {
            return $"Cliente {Nome}, CPF {CPF}, residente em {Cidade}";
        }

    }
}
