namespace self04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double e = 1 / Math.Pow(10, 10);
            for (int j = 1; ; j++)
            {
                double s1 = (double)1 / (j * (j + 1) * (j + 2));
                if (double.Epsilon > s1)
                {
                    break;
                }
                s += s1;
            }
            Console.WriteLine(s);
        }
    }
}
