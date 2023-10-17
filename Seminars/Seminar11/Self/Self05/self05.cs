namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = -9.25 + rnd.NextDouble() * 18.58;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double temp = a[i, j];
                    a[i, j] = a[n - j - 1, n - i - 1];
                    a[n - j - 1, n - i - 1] = temp;
                }
            }
            for (int i = n / 2; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    double temp = a[i, j];
                    a[i, j] = a[n - j - 1, n - i - 1];
                    a[n - j - 1, n - i - 1] = temp;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]:F2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
