namespace ReservaDeHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel r1 = new Hotel("Carlos", 12);
            Hotel r2 = new Hotel("", -8, 0, -300);

            r1.ExibirReserva();
            r2.ExibirReserva();

            Console.WriteLine(r1.CalcularTotal());
            Console.WriteLine(r2.CalcularTotal());

            r1.AdicionarDiarias(2);
            r1.ExibirReserva();

            r2.CancelarReserva();
            r2.ExibirReserva();

            r2.ReativarReserva();
            r2.ExibirReserva();
        }
    }
}
