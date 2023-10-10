namespace self04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-2, 8);
            }
            Array.Sort(a);
            int kc = 0, kn = 0, t1 = 0, t2 = 0;
            foreach (int t in a)
            {
                if (Math.Abs(t) % 2 == 0)
                {
                    kc++;
                }
                else
                {
                    kn++;
                }
            }
            int[] b = new int[kc];
            int[] c = new int[kn];
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i]) % 2 == 0)
                {
                    b[t1] = a[i];
                    t1++;
                }
                else
                {
                    c[t2] = a[i];
                    t2++;
                }
            }
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < t1; i++) Console.Write(b[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < t2; i++) Console.Write(c[i] + " ");
        }
    }
}
