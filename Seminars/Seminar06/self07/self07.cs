namespace self07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите x:");
                if (double.TryParse(Console.ReadLine(), out double x) && x > 0)
                {
                    Console.WriteLine("Введите n:");
                    if (int.TryParse(Console.ReadLine(), out int n) && n >= 1 && n <= 20)
                    {
                        double s = 0;
                        for (int k = 1; k <= n; k++)
                        {
                            double r = Math.Abs(x - k) * Math.Cos(Math.Cbrt(k) * x / (double)2);
                            s += r;
                        }
                        double res = (Math.Log(x) - ((double)2 / (double)9)) * s;
                        Console.WriteLine($"Результат: {res:F3}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
                Console.WriteLine();
                Console.WriteLine("Повторный ввод:");
            }
        }
    }
}
