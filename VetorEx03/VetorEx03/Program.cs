namespace VetorEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[8];
            bool encontrou = false;

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número para buscar: ");
            int busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < 8; i++)
            {
                if (vetor[i] == busca)
                {
                    Console.WriteLine($"Encontrado na posição {i}");
                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("O número não se encontra no vetor");
            }
        }
    }
}
