namespace self01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n - i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = i + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
