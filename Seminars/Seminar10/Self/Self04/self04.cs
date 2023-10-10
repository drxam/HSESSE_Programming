namespace self04
{
    internal class Program
    {
        static void Array_Even(int[] a, ref int[] b)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) % 2 == 0) k++;
            }
            int[] c = new int[b.Length + k];
            Array.Copy(b, c, b.Length);
            k = b.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) % 2 == 0)
                {
                    c[k++] = a[i];
                }
            }
            b = c;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            if (int.TryParse(Console.ReadLine(), out int n1) && int.TryParse(Console.ReadLine(), out int n2) && n1 > 0 && n2 > 0)
            {
                int[] a1 = new int[n1];
                int[] a2 = new int[n2];
                for (int i = 0; i < n1; i++)
                {
                    a1[i] = rnd.Next(-100, 101);
                }
                for (int i = 0; i < n2; i++)
                {
                    a2[i] = rnd.Next(-100, 101);
                }
                Array_Even(a1, ref a2);
                foreach (int i in a1) Console.Write(i + " ");
                Console.WriteLine();
                foreach (int i in a2) Console.Write(i + " ");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
