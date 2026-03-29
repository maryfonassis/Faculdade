namespace MatrizesEVetores06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] matriz = new char[3, 3];
            int contador = 0;
            int linha, coluna;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = ' ';
                }
            }

            while (contador < 9)
            {
                Console.Clear();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{matriz[i, 0]} | {matriz[i, 1]} | {matriz[i, 2]}");
                }

                char jogador;
                if (contador % 2 == 0)
                    jogador = 'X';
                else
                    jogador = 'O';

                Console.WriteLine($"Jogador {jogador}");

                Console.Write("Linha (0 a 2): ");
                linha = int.Parse(Console.ReadLine());

                Console.Write("Coluna (0 a 2): ");
                coluna = int.Parse(Console.ReadLine());

                if (matriz[linha, coluna] == ' ')
                {
                    matriz[linha, coluna] = jogador;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Posição já ocupada!");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Fim de jogo!");



        }
    }
}
