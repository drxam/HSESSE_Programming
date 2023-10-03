namespace sem8
{
    internal class Program
    {
        static void Triangle(int n)
        {
            for (int i = 1;  i <= n; i++)
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
            Triangle(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
