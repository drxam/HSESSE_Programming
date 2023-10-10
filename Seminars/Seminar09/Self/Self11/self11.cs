namespace self11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            a[0] = 1; a[1] = 1;
            for (int i = 2;  i < n; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            foreach (int i in a) Console.Write(i + " ");
        }
    }
}
