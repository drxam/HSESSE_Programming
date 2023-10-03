namespace sem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                for (int t = 1; t <= n; t++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write('*');
                    }
                    for (int j = m - i ; j > 0 ; j--)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
