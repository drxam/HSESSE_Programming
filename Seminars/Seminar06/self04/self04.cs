namespace self04
{
    internal class Program
    {
        static double F(double x, double y, double z) // Превращаем число в знак для мат операций
        {
            switch(z)
            {
                case 1: return x + y;
                case 2: return x - y;
                case 3: return x * y;
                case 4: return x / y;
                default: return 0;
            }
        }
        static char F1(int a) // Превращаем число в знак для вывода
        {
            switch (a)
            {
                case 1: return '+';
                case 2: return '-';
                case 3: return '*';
                case 4: return '/';
                default: return '?';
            }
        }
        static void Main(string[] args)
        {
            for (int a = 1; a <= 4; a++)
            {
                for (int b = 1; b <= 4; b++)
                {
                    for(int c = 1; c <= 4; c++)
                    {
                        for(int  d = 1; d <= 4; d++)
                        {
                            for(int e = 1; e <= 4; e++)
                            {
                                double s = F(F(F(F(F(1, 2, a), 3, b), 4, c), 5, d), 6, e);
                                if (s == 35)
                                {
                                    Console.WriteLine($"((((1{F1(a)}2){F1(b)}3){F1(c)}4){F1(d)}5){F1(e)}6 = 35");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
