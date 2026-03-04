using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteban20Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (num1 + num2));
            Console.WriteLine("Subtração: " + (num1 - num2));
            Console.WriteLine("Multiplicação: " + (num1 * num2));
            Console.WriteLine("Divisão: " + (num1 / (double)num2));

            // EXERCÍCIO 2

            Console.WriteLine("Digite x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite y2:");
            double y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Distância entre os pontos: " + distancia);

            // EXERCÍCIO 3

            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            int C = int.Parse(Console.ReadLine());

            int R = (A + B) * (A + B);
            int S = (B + C) * (B + C);
            int D = R + S;

            Console.WriteLine("O valor de D é: " + D);

            // EXERCÍCIO 4

            Console.WriteLine("Digite a primeira nota (peso 2):");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota (peso 3):");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota (peso 5):");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.WriteLine("Média ponderada: " + media);

            // EXERCÍCIO 5

            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");

            // EXERCÍCIO 6

            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            int c = int.Parse(Console.ReadLine());

            int maior = a;

            if (b > maior) 
            {
                maior = b;
            }
            if (c > maior) 
            { 
                maior = c; 
            }

            Console.WriteLine("O maior número é: " + maior);

            // EXERCÍCIO 7

            Console.WriteLine("Digite o primeiro número:");
            int nA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int nB = int.Parse(Console.ReadLine());

            if (nA > nB)
            {
                Console.WriteLine("Maior número: " + nA);
            }
            else if (nB > nA)
            {
                Console.WriteLine("Maior número: " + nB);
            }
            else
            {
                Console.WriteLine("Números iguais.");
            }

            // EXERCÍCIO 8

            Console.WriteLine("Digite o primeiro número:");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            int p3 = int.Parse(Console.ReadLine());

            if (p1 > 0 && p2 > 0 && p3 > 0)
                Console.WriteLine("Soma: " + (p1 + p2 + p3));
            else
                Console.WriteLine("Erro: todos os números devem ser positivos.");

            // EXERCÍCIO 9

            int contador = 1;
            int soma = 0;

            while (contador <= 100)
            {
                soma += contador;
                contador++;
            }

            Console.WriteLine("Soma de 1 a 100: " + soma);

            // EXERCÍCIO 10

            Console.WriteLine("Digite um número para ver a tabuada:");
            int tab = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(tab + " x " + i + " = " + (tab * i));
            }

            // EXERCÍCIO 11

            Console.WriteLine("Digite um número:");
            int valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (valor < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            // EXERCÍCIO 12

            int soma5 = 0;
            int contador5 = 0;

            do
            {
                Console.WriteLine("Digite um número:");
                int numeroDigitado = int.Parse(Console.ReadLine());
                soma5 += numeroDigitado;
                contador5++;

            } while (contador5 < 5);

            Console.WriteLine("A soma dos 5 números é: " + soma5);

            // EXERCÍCIO 13

            Console.WriteLine("Digite o primeiro número:");
            double op1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double op2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação (+, -, *, /):");
            string operacao = Console.ReadLine();

            if (operacao == "+")
                Console.WriteLine("Resultado: " + (op1 + op2));
            else if (operacao == "-")
                Console.WriteLine("Resultado: " + (op1 - op2));
            else if (operacao == "*")
                Console.WriteLine("Resultado: " + (op1 * op2));
            else if (operacao == "/")
                Console.WriteLine("Resultado: " + (op1 / op2));
            else
                Console.WriteLine("Operação inválida.");

            // EXERCÍCIO 14

            Console.WriteLine("Digite um número inteiro:");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Números pares de 0 até " + limite + ":");

            for (int i = 0; i <= limite; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            // EXERCÍCIO 15

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número:");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    pares++;
                else
                    impares++;
            }

            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);

            // EXERCÍCIO 16

            Console.WriteLine("Digite um número para calcular o fatorial:");
            int fat = int.Parse(Console.ReadLine());

            int resultado = 1;

            for (int i = 1; i <= fat; i++)
            {
                resultado *= i;
            }

            Console.WriteLine("Fatorial de " + fat + " é: " + resultado);

            // EXERCÍCIO 17

            Console.WriteLine("Digite um número para ver seus divisores:");
            int div = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores de " + div + ":");

            for (int i = 1; i <= div; i++)
            {
                if (div % i == 0)
                    Console.WriteLine(i);
            }

            // EXERCÍCIO 18

            int somaIdade = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite uma idade:");
                int idade = int.Parse(Console.ReadLine());
                somaIdade += idade;
            }

            double mediaIdade = somaIdade / 5.0;

            Console.WriteLine("A média das idades é: " + mediaIdade);

            // EXERCÍCIO 19

            Console.WriteLine("Digite um número para verificar se é primo:");
            int primo = int.Parse(Console.ReadLine());

            bool ehPrimo = true;

            if (primo <= 1)
                ehPrimo = false;

            for (int i = 2; i < primo; i++)
            {
                if (primo % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine("O número é primo.");
            }
            else
            {
                Console.WriteLine("O número não é primo.");
            }

            // EXERCÍCIO 20

            Console.WriteLine("Digite um número:");
            double numFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Dobro: " + (numFinal * 2));
            Console.WriteLine("Triplo: " + (numFinal * 3));
            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(numFinal));
        }
    }
}
