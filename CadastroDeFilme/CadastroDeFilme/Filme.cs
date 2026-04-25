namespace CadastroDeFilme
{
    internal class Filme
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int DuracaoMinutos { get; set; }
        public int ClassificacaoIndicativa { get; set; }

        public Filme(string nome, string genero, int duracaoMinutos, int classificacaoIndicativa)
        {
            if (nome == null)
                throw new ArgumentNullException("Nome não pode null");
            else Nome = nome;

            if (genero == null)
                Genero = "Não Informado";
            else Genero = genero;

            if (duracaoMinutos <= 0)
                DuracaoMinutos = 1;
            else DuracaoMinutos = duracaoMinutos;

            if (classificacaoIndicativa < 0)
                ClassificacaoIndicativa = 0;
            else ClassificacaoIndicativa = classificacaoIndicativa;
        }
        public void ExibirResumo()
        {
            Console.WriteLine($"{Nome}, {Genero}, Duração: {DuracaoMinutos}min, Classificação: +{ClassificacaoIndicativa}");
        }
        public bool EhPermitido(int idade)
        {
            if (idade >= ClassificacaoIndicativa)
                return true;
            return false;
        }
        public void AlterarDuracao(int novaDuracao)
        {
            DuracaoMinutos = novaDuracao; 
        }
    }
}
