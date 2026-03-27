namespace VetoresEx04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] resultado = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"V1 - Digite o número {i + 1}: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"V2 - Digite o número {i + 1}: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                resultado[i] = v1[i] + v2[i];
            }

            Console.WriteLine("Vetor resultante:");
            foreach (int num in resultado)
            {
                Console.WriteLine(num);
            }
        }
    }
}
