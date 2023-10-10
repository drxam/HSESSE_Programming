namespace self05
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
                a[i] = r.Next(1, 6);
            }
            foreach (int i in a) Console.Write(i + " ");
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] == a[i]) a[j] = 0; 
                }
            }
            foreach (int i in a) Console.Write(i + " ");
        }
    }
}
