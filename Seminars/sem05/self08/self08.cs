namespace self08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            if (k <= s.Length)
            {
                string s1 = "";
                for (int i = 0; i < k; i++)
                {
                    s1 += s[i];
                }
                Console.WriteLine(s1);
            }
            else
            {
                Console.WriteLine("k больше количества разрядов числа");
            }
        }
    }
}
