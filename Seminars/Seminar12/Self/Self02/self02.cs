namespace self02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = rnd.Next(-9, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int[] temp = new int[m];
                for (int j = 0; j < m; j++)
                {
                    temp[j] = Math.Abs(a[i][j]);
                }
                if (temp.Distinct().Count() == a[i].Count())
                {
                    for (int j = 0; j < m; j++) Console.Write(a[i][j] + " ");
                    Console.WriteLine();
                }

            }
        }
    }
}
