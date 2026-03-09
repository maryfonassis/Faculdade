using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRobson09._03
{
    internal class Boletim
    {
        public Aluno Aluno { get; set; }
        public Professor Professor { get; set; }
        public Diciplina Diciplina { get; set; }
        public Nota Nota { get; set; }

        public Boletim(Aluno aluno, Professor professor, Diciplina diciplina, Nota nota)
        {
            Aluno = aluno;
            Professor = professor;
            Diciplina = diciplina;
            Nota = nota;
        }

        public double Media()
        {
            return (Nota.Nota1 + Nota.Nota2 + Nota.Nota3) / 3.0;
        }
        public string Situacao()
        {
            if (Media() >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        public override string ToString()
        {
            {
                return Aluno.Nome + ", " + Diciplina.Nome + ", " + " Professor: " + Professor.Nome + " Nota 1: "
                    + Nota.Nota1 + " Nota 2: " + Nota.Nota2 + " Nota 3: " + Nota.Nota3 + ", " + " Media: " + Media().ToString("F2") + ", " + Situacao();
            }
        }
    }
}
