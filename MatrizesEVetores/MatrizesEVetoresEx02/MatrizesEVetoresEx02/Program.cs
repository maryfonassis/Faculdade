namespace MatrizesEVetoresEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            double[] precos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nome do produto: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Preço: ");
                precos[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor máximo: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Produtos até esse valor:");
            for (int i = 0; i < 10; i++)
            {
                if (precos[i] <= valor)
                    Console.WriteLine($"{nomes[i]} - R$ {precos[i]}");
            }
        }
    }
}
