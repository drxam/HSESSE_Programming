namespace self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(-5, 6);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    for (int k = j + 1; k < m; k++)
                    {
                        if (a[i, j] > a[i, k])
                        {
                            int temp = a[i, j];
                            a[i, j] = a[i, k];
                            a[i, k] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
