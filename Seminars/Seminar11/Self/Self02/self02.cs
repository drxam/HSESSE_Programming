namespace self02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(-10, 11);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int k = int.Parse(Console.ReadLine());
            k--;
            int s = 0, p = 1;
            if (k < m && k >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    s += a[k, i];
                    p *= a[k, i];
                }
            }
            else
            {
                Console.WriteLine("Такой строки не существует");
            }
            Console.WriteLine(s + " " + p);
        }
    }
}
