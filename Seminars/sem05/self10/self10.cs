namespace self10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double G = x <= 0.5 ? Math.Sin(Math.PI / 2.0) : Math.Sin(Math.PI * (x - 1) / 2.0);
            Console.WriteLine(G);
        }
    }
}
