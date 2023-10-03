namespace self04_3
{
    internal class Program
    {
        static void Minmax(ref double x, ref double y)
        {
            double a = x;
            if (x > y)
            {
                x = y;
                y = a;
            }
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            Minmax(ref a, ref d);
            Minmax(ref b, ref c);
            Minmax(ref a, ref b);
            Minmax(ref c, ref d);
            Console.WriteLine($"min = {a} max = {d}");
        }
    }
}
