namespace self08
{
    internal class Program
    {
        static double F1(double x, double z)
        {
            double s = x * Math.Atan(x / Math.Sqrt(z)) - Math.Log(Math.Cbrt(x * x + z)) + 1;
            return s;
        }
        static double F2(double x, double z)
        {
            double s = Math.Pow(Math.E, Math.Sqrt(z)) + Math.Cbrt(x * x * x * x) * (1 + (x - z / x) / (x + z / x)) * Math.Abs(Math.Sin(x));
            return s;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите входные данные:");
                try
                {
                    Console.WriteLine("Введите кол-во значений X N: (N>0)");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите начальное значение X0:");
                    double X0 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите шаг dX: (dX>0)");
                    double dX = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите кол-во значений Z M: (M>0)");
                    int M = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите начальное значение Z0:");
                    double Z0 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите шаг dZ: (dZ>0)");
                    double dZ = double.Parse(Console.ReadLine());
                    if (N > 0 && M > 0 && dX > 0 && dZ > 0 && Z0 > 0)
                    {
                        Console.WriteLine("Значения функций 1 и 2:");
                        for (double x = X0; Math.Round(x, 2) <= Math.Round(X0 + dX * (N - 1), 2); x = Math.Round(x, 2) + Math.Round(dX, 2))
                        {
                            for (double z = Z0; Math.Round(z, 2) <= Math.Round(Z0 + dZ * (M - 1), 2); z = Math.Round(z, 2) + Math.Round(dZ, 2))
                            {
                                if (x != 0)
                                {
                                    Console.WriteLine($"X = {x:F2} Z = {z:F2} F1 = {F1(x, z):F3} F2 = {F2(x, z):F3}");
                                }
                                else
                                {
                                    Console.WriteLine($"X = {x:F2} Z = {z:F2} F1 = {F1(x, z):F3} F2 не может быть вычислена при X=0");
                                }

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверные входные данные");
                    }
                }
                catch
                {
                    Console.WriteLine("Неверные входные данные");
                }
            }
        }
    }
}
