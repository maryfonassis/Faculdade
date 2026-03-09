using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRobson09._03
{
    internal class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }


        public Aluno(int matricula, string nome, int idade)
        {
            Matricula = matricula;
            Nome = nome;
            Idade = idade;
        }
    }
}
