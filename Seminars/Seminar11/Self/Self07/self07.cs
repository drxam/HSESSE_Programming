namespace self07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] a = new char[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = i % 2 == 0 ? (char)rnd.Next(65, 91) : (char)rnd.Next(48, 58);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            string s = "";
            for (int i = 0; i < n; i++) s += a[i, i];
            Console.WriteLine();
            Console.WriteLine(s);
        }
    }
}
