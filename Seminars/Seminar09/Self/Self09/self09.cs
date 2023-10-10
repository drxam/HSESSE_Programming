namespace self09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = 2 * (i + 1) - 1;
            }
            foreach (int i in a) Console.Write(i + " ");
        }
    }
}
