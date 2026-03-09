using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRobson09._03
{
    internal class Nota
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Nota()
        {
        }

        public Nota(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
    }
}
