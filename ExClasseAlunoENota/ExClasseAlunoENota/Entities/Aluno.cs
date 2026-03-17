using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasseAlunoENota.Entities
{
    internal class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabaho { get; set; }
        public double NotaFinal { private get; set; }


        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabaho) / 2;
        }
        public bool CalcularNotaFinal()
        {
            double NotaNecessaria = 14;
            if ( NotaNecessaria <= (NotaProva + NotaTrabaho))
            {
                Console.Write("Passou: ");
                return true;
            }
                Console.WriteLine($"Nota necessaria para passar, {NotaNecessaria - (NotaProva + NotaTrabaho)}");
                 return false;

        }
        public double ImprimirNotaFinal()
        {
            return NotaFinal;
        }
        public void ReceberDados()
        {
            Console.Write("RA:");
            RA = Console.ReadLine();
            Console.Write("Nome Aluno:");
            Nome = Console.ReadLine();
            Console.Write("Nota Prova:");
            NotaProva = double.Parse(Console.ReadLine());
            Console.Write("Nota Trabalho:");
            NotaProva = double.Parse(Console.ReadLine());
        }




    }
}
