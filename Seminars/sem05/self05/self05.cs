namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= k; i++)
            {
                s += (double)1 / (double)i;
            }
            Console.WriteLine($"{s:F4}");
        }
    }
}
