namespace self09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            bool g = (Math.Sqrt(x * x + y * y) <= 2 && y - x <= 0 && x >= 0 && y <= Math.Sqrt(2)) ? true : false;
            Console.WriteLine(g);
        }
    }
}
