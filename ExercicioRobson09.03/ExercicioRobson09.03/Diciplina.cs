using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRobson09._03
{
    internal class Diciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double CargaHoraria { get; set; }


        public Diciplina(int codigo, string nome, double cargaHoraria)
        {
            Codigo = codigo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }
    }
}
