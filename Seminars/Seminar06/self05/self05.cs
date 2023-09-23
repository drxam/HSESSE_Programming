namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A:");
            double a = Convert.ToDouble(Console.ReadLine());
            double s = 0, p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p * (a - i);
                double a1 = 1;
                for (int j = 1; j <= i; j++)
                {
                    a1 = a1 * a;
                }
                a1 = (double)1 / a1;
                s = s + a1;
            }
            Console.WriteLine($"S = {s:F3} P = {p}");
        }
    }
}
