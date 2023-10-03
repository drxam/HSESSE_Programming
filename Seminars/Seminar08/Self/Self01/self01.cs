namespace sem8
{
    internal class Program
    {
        static void Pi1(out double a, out int i1)
        {
            int z = 0;
            double res = 0;
            for (int i = 0; i <= 10;  i++)
            {
                res += Math.Pow(16, -i) * (4.0 / (8 * i + 1) - 2.0 / (8 * i + 4) - 1.0 / (8 * i + 5) - 1.0 / (8 * i + 6));
                if (Math.Round(res, 3) == 3.142)
                {
                    z = i;
                    break;
                }
                else
                {
                    z = i;
                }
            }
            i1 = z;
            a = res;
        }
        static void Pi2(out double a, out int i2)
        {
            int z = 0;
            double res = 0;
            for (int k = 1; k <= 100;  k++)
            {
                double s1 = 0;
                for (int m = 1; m <= k; m++)
                {
                    s1 += 1.0 / (m * (k + 1) * (k + 1) * (k + 1));
                }
                res += s1;
                if (Math.Round(res, 2) == 3.14)
                {
                    z = k;
                    break;
                }
                else
                {
                    z = k;
                }
            }
            i2 = z;
            a = Math.Sqrt(Math.Sqrt(360 * res));
        }
        static void Main(string[] args)
        {
            double a1 = 0, a2 = 0;
            int i1 = 0, i2 = 0;
            do
            {
                Console.WriteLine("Выберите метод для вычисления числа пи: (1 или 2)");
                int z = int.Parse(Console.ReadLine());
                if (z == 1)
                {
                    Pi1(out a1, out i1);
                    Console.WriteLine(i1 + " " + a1);
                }
                else
                {
                    Pi2(out a2, out i2);
                    Console.WriteLine(i2 + " " + a2);
                }
                Console.WriteLine("Для повтора нажмите Enter; для выхода нажмите Escape");
                Console.WriteLine();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
