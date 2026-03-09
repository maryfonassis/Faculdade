using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRobson09._03
{
    internal class Professor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Formacao { get; set; }


        public Professor(int codigo, string nome, string formacao)
        {
            Codigo = codigo;
            Nome = nome;
            Formacao = formacao;
        }
    }
}
