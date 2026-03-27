namespace VetoresEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            Console.WriteLine($"Soma total: {soma}");
        }
    }
}
