namespace self06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 5; n <= 12 ; n++)
            {
                int s = 0;

                for (int k = 1; k <= n; k++)
                {
                    int res = 1;
                    for (int i = 1; i <= k; i++)
                    {
                        res = res * i;
                    }
                    s += res;
                }
                Console.WriteLine($"n:{n, 3} S(n) = {s}");
            }
        }
    }
}
