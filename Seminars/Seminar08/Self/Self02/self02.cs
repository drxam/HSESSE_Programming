namespace self02
{
    internal class Program
    {
        public static bool Triangle(double x, double y, double z, out double p, out double s)
        {
            double ma = Math.Max(Math.Max(x, y), Math.Max(y, z));
            double mi = Math.Min(Math.Min(x, y), Math.Min(y, z));
            double pp = (x + y + z) / 2.0;
            if (mi + (x + y + z - mi - ma) > ma)
            {
                p = x + y + z;
                s = Math.Sqrt(pp * (pp - x) * (pp - y) * (pp - z));
                return true;
            }
            else
            {
                p = 0;
                s = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            double s, p;
            if (Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), out p, out s))
            {
                Console.WriteLine($"P = {p} S = {s:F3}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}
