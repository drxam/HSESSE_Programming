namespace self08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = (int)Math.Pow(2, i);
            }
            foreach (int i in a) Console.Write(i + " ");
        }
    }
}
