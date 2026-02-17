

namespace Exercicio3.Entities
{
    internal class Pessoa
    {
        public double Altura { get; set; }
        public char Sexo { get; set; }

        public Pessoa(double altura, char sexo)
        {
            Altura = altura;
            Sexo = sexo;
        }

        public double PesoIdealFeminino() 
        { 
            return (62.1 *  Altura) - 44.7;
        }
        public double PesoIdealMasculino()
        {
            return (72.7 * Altura) - 58.0;
        }
    }
}
