namespace self02
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
