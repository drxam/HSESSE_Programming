namespace self07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Random rnd = new Random();
            int[] b = new int[10];
            for (int i = 0; i < 10; i++)
            {
                b[i] = rnd.Next(-12, 15);
            }
            Console.WriteLine("Массив a:");
            foreach (int i in a) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("Массив b:");
            foreach (int i in b) Console.Write(i + " ");
            int k = 0;
            for (int i = 0; i < 20; i++)
            {
                if (Math.Abs(a[i]) % 2 == 0)
                    k++;
            }
            int[] c = new int[k + 10];
            for (int i = 0; i < 10; i++)
            {
                c[i] = b[i];
            }
            int z = 0;
            for (int i = 0; i < 20; i++)
            {
                if (Math.Abs(a[i]) % 2 == 0)
                {
                    c[10 + z] = a[i];
                    z++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив c:");
            foreach (int i in c) Console.Write(i + " ");
        }
    }
}
