namespace VetoresEx07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;

            for (int i = vetor1.Length - 1; i >= 0; i--)
            {
                vetor2[j] = vetor1[i];
                j++;
            }

            Console.WriteLine("Vetor invertido:");

            foreach (int num in vetor2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
