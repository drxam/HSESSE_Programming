namespace self10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), a = int.Parse(Console.ReadLine()), d = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            m[0] = a;
            for (int i = 1; i < n; i++)
            {
                m[i] = a + i * d;
            }
            foreach (int i in m) Console.Write(i + " ");
        }
    }
}
