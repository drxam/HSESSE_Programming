namespace sem8
{
    internal class Program
    {
        static void Ornament(int N, int M)
        {
            for (int z = 1; z <= M; z++)
            {
                Triangle(N);
            }
        }
        static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Ornament(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        }
    }
}
