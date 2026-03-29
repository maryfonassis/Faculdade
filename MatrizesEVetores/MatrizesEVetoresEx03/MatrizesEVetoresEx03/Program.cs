namespace MatrizesEVetoresEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Soma de cada linha:");
            for (int i = 0; i < 3; i++)
            {
                int soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine($"Linha {i}: {soma}");
            }
        }
    }
}
