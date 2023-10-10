namespace self06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    for (int j = i + 1;  j < s.Length; j++)
                    {
                        if (s[j] == ')') break;
                        k++;
                        Console.Write(s[j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(k);
        }
    }
}
