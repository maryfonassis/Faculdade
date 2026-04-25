using System;

namespace ClasseAlunoENota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.ReceberDados();
            aluno.CalcularNotaFinal();
            aluno.CalcularMedia();
            aluno.ImprimirNotaFinal();

        }
    }
}