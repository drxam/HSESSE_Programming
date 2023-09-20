namespace self02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            double s = 0;
            double t = A / N, t1 = t;
            while (t1 <= A)
            {
                s += t * t1 * t1;
                t1 = t1 + t;
            }
            Console.WriteLine(s);
        }
    }
}
