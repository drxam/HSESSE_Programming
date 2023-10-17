namespace self01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[,] a = new int[n, n];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    z = i + 1;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = z;
                        z++;
                        if (z > n) z = 1;
                    }
                }
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
