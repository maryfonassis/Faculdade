namespace VetoresEx06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salarios = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Salário do funcionário {i + 1}: ");
                salarios[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                salarios[i] *= 1.05;
            }

            Console.WriteLine("Salários reajustados:");

            foreach (double s in salarios)
            {
                Console.WriteLine(s);
            }
        }
    }
}
