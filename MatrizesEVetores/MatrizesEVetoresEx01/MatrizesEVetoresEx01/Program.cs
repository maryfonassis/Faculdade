namespace MatrizesEVetoresEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Digite o número {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Valores nas posições pares:");
            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Posição {i}: {vetor[i]}");
            }
        }
    }
}
