namespace self06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                string s = Convert.ToString(i);
                if (s[0] == s[1] && s[1] == s[2])
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
