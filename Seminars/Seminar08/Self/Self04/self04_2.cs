namespace self04_2
{
    internal class Program
    {
        static void InvertDigits(ref int k)
        {
            string s = Convert.ToString(k);
            string s1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 += s[i];
            }
            while (s1[0] == '0')
            {
                s1 = s1[1..^0];
            }
            k = Convert.ToInt32(s1);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            InvertDigits(ref a);
            Console.WriteLine(a);
        }
    }
}
