namespace self03
{
    internal class Program
    {
        static int F(string a)
        {
            bool f = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i]) f = false;
                }
            }
            if (f) Console.WriteLine(a);
            return f ? 1 : 0;
        }
        static void Main(string[] args)
        {
            int k = 0;
            for(int i = 2000; i <= 3000; i++)
            {
                k += F(Convert.ToString(i));
            }
            Console.WriteLine($"Количество таких чисел - {k}");
        }
    }
}
