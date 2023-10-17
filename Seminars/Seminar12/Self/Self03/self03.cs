namespace self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > 0 && n % 2 != 0)
                {
                    int[][] a = new int[n][];
                    for (int i = 0; i <= n / 2; i++)
                    {
                        a[i] = new int[i + 1];
                    }
                    for (int i = n / 2 + 1; i < n; i++)
                    {
                        a[i] = new int[n - i];
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < a[i].Length; j++)
                        {
                            a[i][j] = j + 1;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        foreach (int t in a[i]) Console.Write(t + " ");
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("число строк должно быть нечетным. повторите ввод");
                    continue;
                }
            }
        }
    }
}
